﻿#region Usings

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using SIM.Base;
using SIM.Pipelines.Processors;

#endregion

namespace SIM.Pipelines
{

  #region

  #endregion

  /// <summary>
  ///   The pipeline manager.
  /// </summary>
  public static class PipelineManager
  {
    #region Static Fields

    public static string PipelinesConfigFilePath = "Pipelines.config";

    /// <summary>
    ///   The definitions.
    /// </summary>
    private static readonly Dictionary<string, PipelineDefinition> Definitions = new Dictionary<string, PipelineDefinition>();

    #endregion

    #region Public Methods and Operators

    /// <summary>
    ///   The get pipelines.
    /// </summary>
    /// <returns> </returns>
    [NotNull]
    public static XmlElement GetPipelines(XmlDocumentEx document)
    {
      Assert.ArgumentNotNull(document, "document");

      XmlElement pipelinesNode = document.SelectSingleNode("configuration/pipelines") as XmlElement;
      Assert.IsNotNull(pipelinesNode, "Can't find pipelines configuration node");
      
      return pipelinesNode;
    }

    /// <summary>
    ///   The initialize.
    /// </summary>
    public static XmlElement Initialize(string pipelinesConfigFilePath = null)
    {
      var document = XmlDocumentEx.LoadFile(pipelinesConfigFilePath.EmptyToNull() ?? PipelinesConfigFilePath);
      XmlElement pipelinesNode = GetPipelines(document);

      return Initialize(pipelinesNode);
    }

    public static XmlElement Initialize(XmlElement pipelinesNode)
    {
      Log.Debug("Pipelines RAW configuration: " + pipelinesNode.OuterXml);
      Definitions.Clear();
      var resultXmlConfig = XmlDocumentEx.LoadXml("<pipelines />");
      
      foreach (XmlElement element in pipelinesNode.ChildNodes.OfType<XmlElement>())
      {
        string pipelineName = element.Name;
        string title = element.GetAttribute("title");
        Assert.IsNotNullOrEmpty(title, "The '{0}' pipeline definition doesn't contain the title attribute".FormatWith(pipelineName));

        var pipelineNode = resultXmlConfig.DocumentElement.AddElement(pipelineName);
        pipelineNode.SetAttribute("title", title);

        List<StepDefinition> steps = new List<StepDefinition>();
        XmlNodeList stepNodes = element.SelectNodes("step");
        //Processors are placed into steps
        if (stepNodes != null && stepNodes.Count > 0)
        {
          foreach (XmlElement step in stepNodes.OfType<XmlElement>())
          {
            //Clever mechanism of steps reusing. Doesn't seem to be used somewhere.
            string fromPipeline = step.GetAttribute("pipeline");
            string args = step.GetAttribute("args").EmptyToNull();
            if (!string.IsNullOrEmpty(fromPipeline))
            {
              PipelineDefinition def = Definitions[fromPipeline];
              if (args != null)
              {
                def.Steps.ForEach(s => s.ArgsName = args);
              }

              AddSteps(steps, def);
            }
            //All step's processors are interted to the step
            else
            {
              var stepNode = pipelineNode.AddElement("step");
              stepNode.SetAttribute("args", args);

              List<ProcessorDefinition> processorDefinitions = ProcessorManager.GetProcessors(step, pipelineName, stepNode);
              AddStep(steps, processorDefinitions);
            }
          }
        }
        //Otherwise all the processors are placed into the default step.
        else
        {
          List<ProcessorDefinition> processorDefinitions = ProcessorManager.GetProcessors(element, pipelineName, pipelineNode);
          steps.Add(new StepDefinition(processorDefinitions));
        }

        Definitions.Add(pipelineName, new PipelineDefinition { Steps = steps, Title = title });
      }

      return resultXmlConfig.DocumentElement;
    }

    private static void AddSteps(List<StepDefinition> steps, PipelineDefinition def)
    {
      steps.AddRange(def.Steps);
    }

    private static void AddStep(List<StepDefinition> steps, List<ProcessorDefinition> processorDefinitions)
    {
      steps.Add(new StepDefinition(processorDefinitions));
    }

    /// <summary>
    /// The start pipeline.
    /// </summary>
    /// <param name="pipelineName">
    /// The pipeline name. 
    /// </param>
    /// <param name="args">
    /// The args. 
    /// </param>
    /// <param name="pipelineController">
    /// The pipeline controller. 
    /// </param>
    /// <param name="isAsync">
    /// </param>
    public static void StartPipeline([NotNull] string pipelineName, [NotNull] ProcessorArgs args, [CanBeNull] IPipelineController pipelineController = null, bool isAsync = true)
    {
      Assert.ArgumentNotNull(pipelineName, "pipelineName");
      Assert.ArgumentNotNull(args, "args");

      Log.Info("Pipeline '{0}' starts, isAsync: {1}".FormatWith(pipelineName, isAsync.ToString(CultureInfo.InvariantCulture)), typeof(PipelineManager));
      using (new ProfileSection("Start pipeline", typeof(PipelineManager)))
      {
        ProfileSection.Argument("pipelineName", pipelineName);
        ProfileSection.Argument("args", args);
        ProfileSection.Argument("pipelineController", pipelineController);
        ProfileSection.Argument("isAsync", isAsync);

        var pipeline = CreatePipeline(pipelineName, args, pipelineController, isAsync);
        pipeline.Start();
      }
    }

    #endregion

    #region Methods

    /// <summary>
    /// The create pipeline.
    /// </summary>
    /// <param name="pipelineName">
    /// The pipeline name. 
    /// </param>
    /// <param name="args">
    /// The args. 
    /// </param>
    /// <param name="controller">
    /// The controller. 
    /// </param>
    /// <param name="isAsync">
    /// </param>
    /// <returns>
    /// </returns>
    [NotNull]
    private static Pipeline CreatePipeline([NotNull] string pipelineName, [NotNull] ProcessorArgs args, [CanBeNull] IPipelineController controller = null, bool isAsync = true)
    {
      Assert.ArgumentNotNull(pipelineName, "pipelineName");
      Assert.ArgumentNotNull(args, "args");

      using (new ProfileSection("Create pipeline", typeof(PipelineManager)))
      {
        ProfileSection.Argument("pipelineName", pipelineName);
        ProfileSection.Argument("args", args);
        ProfileSection.Argument("controller", controller);
        ProfileSection.Argument("isAsync", isAsync);

        Assert.IsNotNull(Definitions.ContainsKey(pipelineName), "The {0} pipeline defintion does not exist".FormatWith(pipelineName));
        PipelineDefinition definition = Definitions[pipelineName];

        Pipeline pipeline = new Pipeline(definition, args, controller, isAsync);
        if (controller != null)
        {
          controller.Pipeline = pipeline;
        }

        return ProfileSection.Result(pipeline);
      }
    }

    #endregion
  }
}
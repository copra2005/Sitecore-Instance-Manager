﻿namespace SIM.Pipelines.SitecoreWebservices {
  [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Credentials", Namespace="http://sitecore.net/visual/")]
    [System.SerializableAttribute()]
    public partial class Credentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
    [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;

    [System.NonSerializedAttribute()]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CustomData {
            get {
                return this.CustomDataField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomDataField, value) != true)) {
                    this.CustomDataField = value;
                    this.RaisePropertyChanged("CustomData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }

    #region IExtensibleDataObject Members

    [global::System.ComponentModel.BrowsableAttribute(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
      get {
        return this.extensionDataField;
      }
      set {
        this.extensionDataField = value;
      }
    }

    #endregion

    #region INotifyPropertyChanged Members

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    #endregion

    protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="Visual Sitecore ServiceSoap", Namespace="http://sitecore.net/visual/", ConfigurationName="SitecoreWebservices.VisualSitecoreServiceSoap")]
    public interface VisualSitecoreServiceSoap {
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/AddFromMaster", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.AddFromMasterResponse AddFromMaster(SIM.Pipelines.SitecoreWebservices.AddFromMasterRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/AddFromTemplate", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.AddFromTemplateResponse AddFromTemplate(SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/AddVersion", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.AddVersionResponse AddVersion(SIM.Pipelines.SitecoreWebservices.AddVersionRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/CopyTo", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.CopyToResponse CopyTo(SIM.Pipelines.SitecoreWebservices.CopyToRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/Delete", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.DeleteResponse Delete(SIM.Pipelines.SitecoreWebservices.DeleteRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/DeleteChildren", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.DeleteChildrenResponse DeleteChildren(SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/Duplicate", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.DuplicateResponse Duplicate(SIM.Pipelines.SitecoreWebservices.DuplicateRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetChildren", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetChildrenResponse GetChildren(SIM.Pipelines.SitecoreWebservices.GetChildrenRequest request);
        
        // CODEGEN: Generating message contract since element name credentials from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetDatabases", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetDatabasesResponse GetDatabases(SIM.Pipelines.SitecoreWebservices.GetDatabasesRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetItemMasters", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetItemMastersResponse GetItemMasters(SIM.Pipelines.SitecoreWebservices.GetItemMastersRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetItemFields", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetItemFieldsResponse GetItemFields(SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequest request);
        
        // CODEGEN: Generating message contract since element name databaseName from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetLanguages", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetLanguagesResponse GetLanguages(SIM.Pipelines.SitecoreWebservices.GetLanguagesRequest request);
        
        // CODEGEN: Generating message contract since element name databaseName from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetMasters", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetMastersResponse GetMasters(SIM.Pipelines.SitecoreWebservices.GetMastersRequest request);
        
        // CODEGEN: Generating message contract since element name databaseName from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetTemplates", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetTemplatesResponse GetTemplates(SIM.Pipelines.SitecoreWebservices.GetTemplatesRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/GetXML", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.GetXMLResponse GetXML(SIM.Pipelines.SitecoreWebservices.GetXMLRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/InsertXML", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.InsertXMLResponse InsertXML(SIM.Pipelines.SitecoreWebservices.InsertXMLRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/MoveTo", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.MoveToResponse MoveTo(SIM.Pipelines.SitecoreWebservices.MoveToRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/RemoveVersion", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.RemoveVersionResponse RemoveVersion(SIM.Pipelines.SitecoreWebservices.RemoveVersionRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/Rename", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.RenameResponse Rename(SIM.Pipelines.SitecoreWebservices.RenameRequest request);
        
        // CODEGEN: Generating message contract since element name xml from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/Save", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.SaveResponse Save(SIM.Pipelines.SitecoreWebservices.SaveRequest request);
        
        // CODEGEN: Generating message contract since element name credentials from namespace http://sitecore.net/visual/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/visual/VerifyCredentials", ReplyAction="*")]
        SIM.Pipelines.SitecoreWebservices.VerifyCredentialsResponse VerifyCredentials(SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFromMasterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFromMaster", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddFromMasterRequestBody Body;
        
        public AddFromMasterRequest() {
        }
        
        public AddFromMasterRequest(SIM.Pipelines.SitecoreWebservices.AddFromMasterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddFromMasterRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string masterID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;

      public AddFromMasterRequestBody() {
        }
        
        public AddFromMasterRequestBody(string id, string masterID, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.masterID = masterID;
            this.name = name;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFromMasterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFromMasterResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddFromMasterResponseBody Body;
        
        public AddFromMasterResponse() {
        }
        
        public AddFromMasterResponse(SIM.Pipelines.SitecoreWebservices.AddFromMasterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddFromMasterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AddFromMasterResult;
        
        public AddFromMasterResponseBody() {
        }
        
        public AddFromMasterResponseBody(System.Xml.Linq.XElement AddFromMasterResult) {
            this.AddFromMasterResult = AddFromMasterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFromTemplateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFromTemplate", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequestBody Body;
        
        public AddFromTemplateRequest() {
        }
        
        public AddFromTemplateRequest(SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddFromTemplateRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string templateID;

      public AddFromTemplateRequestBody() {
        }
        
        public AddFromTemplateRequestBody(string id, string templateID, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.templateID = templateID;
            this.name = name;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFromTemplateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFromTemplateResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddFromTemplateResponseBody Body;
        
        public AddFromTemplateResponse() {
        }
        
        public AddFromTemplateResponse(SIM.Pipelines.SitecoreWebservices.AddFromTemplateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddFromTemplateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AddFromTemplateResult;
        
        public AddFromTemplateResponseBody() {
        }
        
        public AddFromTemplateResponseBody(System.Xml.Linq.XElement AddFromTemplateResult) {
            this.AddFromTemplateResult = AddFromTemplateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddVersion", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddVersionRequestBody Body;
        
        public AddVersionRequest() {
        }
        
        public AddVersionRequest(SIM.Pipelines.SitecoreWebservices.AddVersionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddVersionRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string language;

      public AddVersionRequestBody() {
        }
        
        public AddVersionRequestBody(string id, string language, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.language = language;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddVersionResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.AddVersionResponseBody Body;
        
        public AddVersionResponse() {
        }
        
        public AddVersionResponse(SIM.Pipelines.SitecoreWebservices.AddVersionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class AddVersionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AddVersionResult;
        
        public AddVersionResponseBody() {
        }
        
        public AddVersionResponseBody(System.Xml.Linq.XElement AddVersionResult) {
            this.AddVersionResult = AddVersionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CopyToRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CopyTo", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.CopyToRequestBody Body;
        
        public CopyToRequest() {
        }
        
        public CopyToRequest(SIM.Pipelines.SitecoreWebservices.CopyToRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class CopyToRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string newParent;

      public CopyToRequestBody() {
        }
        
        public CopyToRequestBody(string id, string newParent, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.newParent = newParent;
            this.name = name;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CopyToResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CopyToResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.CopyToResponseBody Body;
        
        public CopyToResponse() {
        }
        
        public CopyToResponse(SIM.Pipelines.SitecoreWebservices.CopyToResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class CopyToResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement CopyToResult;
        
        public CopyToResponseBody() {
        }
        
        public CopyToResponseBody(System.Xml.Linq.XElement CopyToResult) {
            this.CopyToResult = CopyToResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DeleteRequestBody Body;
        
        public DeleteRequest() {
        }
        
        public DeleteRequest(SIM.Pipelines.SitecoreWebservices.DeleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DeleteRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool recycle;

      public DeleteRequestBody() {
        }
        
        public DeleteRequestBody(string id, bool recycle, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.recycle = recycle;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DeleteResponseBody Body;
        
        public DeleteResponse() {
        }
        
        public DeleteResponse(SIM.Pipelines.SitecoreWebservices.DeleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DeleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement DeleteResult;
        
        public DeleteResponseBody() {
        }
        
        public DeleteResponseBody(System.Xml.Linq.XElement DeleteResult) {
            this.DeleteResult = DeleteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteChildrenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteChildren", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequestBody Body;
        
        public DeleteChildrenRequest() {
        }
        
        public DeleteChildrenRequest(SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DeleteChildrenRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string id;

      public DeleteChildrenRequestBody() {
        }
        
        public DeleteChildrenRequestBody(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteChildrenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteChildrenResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DeleteChildrenResponseBody Body;
        
        public DeleteChildrenResponse() {
        }
        
        public DeleteChildrenResponse(SIM.Pipelines.SitecoreWebservices.DeleteChildrenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DeleteChildrenResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement DeleteChildrenResult;
        
        public DeleteChildrenResponseBody() {
        }
        
        public DeleteChildrenResponseBody(System.Xml.Linq.XElement DeleteChildrenResult) {
            this.DeleteChildrenResult = DeleteChildrenResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DuplicateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Duplicate", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DuplicateRequestBody Body;
        
        public DuplicateRequest() {
        }
        
        public DuplicateRequest(SIM.Pipelines.SitecoreWebservices.DuplicateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DuplicateRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;

      public DuplicateRequestBody() {
        }
        
        public DuplicateRequestBody(string id, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.name = name;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DuplicateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DuplicateResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.DuplicateResponseBody Body;
        
        public DuplicateResponse() {
        }
        
        public DuplicateResponse(SIM.Pipelines.SitecoreWebservices.DuplicateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class DuplicateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement DuplicateResult;
        
        public DuplicateResponseBody() {
        }
        
        public DuplicateResponseBody(System.Xml.Linq.XElement DuplicateResult) {
            this.DuplicateResult = DuplicateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChildrenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChildren", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetChildrenRequestBody Body;
        
        public GetChildrenRequest() {
        }
        
        public GetChildrenRequest(SIM.Pipelines.SitecoreWebservices.GetChildrenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetChildrenRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string id;

      public GetChildrenRequestBody() {
        }
        
        public GetChildrenRequestBody(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChildrenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChildrenResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetChildrenResponseBody Body;
        
        public GetChildrenResponse() {
        }
        
        public GetChildrenResponse(SIM.Pipelines.SitecoreWebservices.GetChildrenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetChildrenResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetChildrenResult;
        
        public GetChildrenResponseBody() {
        }
        
        public GetChildrenResponseBody(System.Xml.Linq.XElement GetChildrenResult) {
            this.GetChildrenResult = GetChildrenResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDatabasesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDatabases", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetDatabasesRequestBody Body;
        
        public GetDatabasesRequest() {
        }
        
        public GetDatabasesRequest(SIM.Pipelines.SitecoreWebservices.GetDatabasesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetDatabasesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;
        
        public GetDatabasesRequestBody() {
        }
        
        public GetDatabasesRequestBody(SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDatabasesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDatabasesResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetDatabasesResponseBody Body;
        
        public GetDatabasesResponse() {
        }
        
        public GetDatabasesResponse(SIM.Pipelines.SitecoreWebservices.GetDatabasesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetDatabasesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetDatabasesResult;
        
        public GetDatabasesResponseBody() {
        }
        
        public GetDatabasesResponseBody(System.Xml.Linq.XElement GetDatabasesResult) {
            this.GetDatabasesResult = GetDatabasesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemMastersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemMasters", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetItemMastersRequestBody Body;
        
        public GetItemMastersRequest() {
        }
        
        public GetItemMastersRequest(SIM.Pipelines.SitecoreWebservices.GetItemMastersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetItemMastersRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string id;

      public GetItemMastersRequestBody() {
        }
        
        public GetItemMastersRequestBody(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemMastersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemMastersResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetItemMastersResponseBody Body;
        
        public GetItemMastersResponse() {
        }
        
        public GetItemMastersResponse(SIM.Pipelines.SitecoreWebservices.GetItemMastersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetItemMastersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetItemMastersResult;
        
        public GetItemMastersResponseBody() {
        }
        
        public GetItemMastersResponseBody(System.Xml.Linq.XElement GetItemMastersResult) {
            this.GetItemMastersResult = GetItemMastersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemFieldsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemFields", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequestBody Body;
        
        public GetItemFieldsRequest() {
        }
        
        public GetItemFieldsRequest(SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetItemFieldsRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
      public bool allFields;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string language;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string version;

      public GetItemFieldsRequestBody() {
        }
        
        public GetItemFieldsRequestBody(string id, string language, string version, bool allFields, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.language = language;
            this.version = version;
            this.allFields = allFields;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemFieldsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemFieldsResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetItemFieldsResponseBody Body;
        
        public GetItemFieldsResponse() {
        }
        
        public GetItemFieldsResponse(SIM.Pipelines.SitecoreWebservices.GetItemFieldsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetItemFieldsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetItemFieldsResult;
        
        public GetItemFieldsResponseBody() {
        }
        
        public GetItemFieldsResponseBody(System.Xml.Linq.XElement GetItemFieldsResult) {
            this.GetItemFieldsResult = GetItemFieldsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLanguagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLanguages", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetLanguagesRequestBody Body;
        
        public GetLanguagesRequest() {
        }
        
        public GetLanguagesRequest(SIM.Pipelines.SitecoreWebservices.GetLanguagesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetLanguagesRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string databaseName;

      public GetLanguagesRequestBody() {
        }
        
        public GetLanguagesRequestBody(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLanguagesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLanguagesResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetLanguagesResponseBody Body;
        
        public GetLanguagesResponse() {
        }
        
        public GetLanguagesResponse(SIM.Pipelines.SitecoreWebservices.GetLanguagesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetLanguagesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetLanguagesResult;
        
        public GetLanguagesResponseBody() {
        }
        
        public GetLanguagesResponseBody(System.Xml.Linq.XElement GetLanguagesResult) {
            this.GetLanguagesResult = GetLanguagesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMastersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMasters", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetMastersRequestBody Body;
        
        public GetMastersRequest() {
        }
        
        public GetMastersRequest(SIM.Pipelines.SitecoreWebservices.GetMastersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetMastersRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string databaseName;

      public GetMastersRequestBody() {
        }
        
        public GetMastersRequestBody(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMastersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMastersResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetMastersResponseBody Body;
        
        public GetMastersResponse() {
        }
        
        public GetMastersResponse(SIM.Pipelines.SitecoreWebservices.GetMastersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetMastersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetMastersResult;
        
        public GetMastersResponseBody() {
        }
        
        public GetMastersResponseBody(System.Xml.Linq.XElement GetMastersResult) {
            this.GetMastersResult = GetMastersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTemplatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTemplates", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetTemplatesRequestBody Body;
        
        public GetTemplatesRequest() {
        }
        
        public GetTemplatesRequest(SIM.Pipelines.SitecoreWebservices.GetTemplatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetTemplatesRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string databaseName;

      public GetTemplatesRequestBody() {
        }
        
        public GetTemplatesRequestBody(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTemplatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTemplatesResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetTemplatesResponseBody Body;
        
        public GetTemplatesResponse() {
        }
        
        public GetTemplatesResponse(SIM.Pipelines.SitecoreWebservices.GetTemplatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetTemplatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetTemplatesResult;
        
        public GetTemplatesResponseBody() {
        }
        
        public GetTemplatesResponseBody(System.Xml.Linq.XElement GetTemplatesResult) {
            this.GetTemplatesResult = GetTemplatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetXML", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetXMLRequestBody Body;
        
        public GetXMLRequest() {
        }
        
        public GetXMLRequest(SIM.Pipelines.SitecoreWebservices.GetXMLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetXMLRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
      public bool deep;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string id;

      public GetXMLRequestBody() {
        }
        
        public GetXMLRequestBody(string id, bool deep, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.deep = deep;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetXMLResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.GetXMLResponseBody Body;
        
        public GetXMLResponse() {
        }
        
        public GetXMLResponse(SIM.Pipelines.SitecoreWebservices.GetXMLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class GetXMLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetXMLResult;
        
        public GetXMLResponseBody() {
        }
        
        public GetXMLResponseBody(System.Xml.Linq.XElement GetXMLResult) {
            this.GetXMLResult = GetXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertXML", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.InsertXMLRequestBody Body;
        
        public InsertXMLRequest() {
        }
        
        public InsertXMLRequest(SIM.Pipelines.SitecoreWebservices.InsertXMLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class InsertXMLRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public bool changeIDs;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string id;
        
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string xml;

      public InsertXMLRequestBody() {
        }
        
        public InsertXMLRequestBody(string id, string xml, bool changeIDs, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.xml = xml;
            this.changeIDs = changeIDs;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertXMLResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.InsertXMLResponseBody Body;
        
        public InsertXMLResponse() {
        }
        
        public InsertXMLResponse(SIM.Pipelines.SitecoreWebservices.InsertXMLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class InsertXMLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement InsertXMLResult;
        
        public InsertXMLResponseBody() {
        }
        
        public InsertXMLResponseBody(System.Xml.Linq.XElement InsertXMLResult) {
            this.InsertXMLResult = InsertXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoveToRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoveTo", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.MoveToRequestBody Body;
        
        public MoveToRequest() {
        }
        
        public MoveToRequest(SIM.Pipelines.SitecoreWebservices.MoveToRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class MoveToRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string newParent;

      public MoveToRequestBody() {
        }
        
        public MoveToRequestBody(string id, string newParent, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.newParent = newParent;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoveToResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoveToResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.MoveToResponseBody Body;
        
        public MoveToResponse() {
        }
        
        public MoveToResponse(SIM.Pipelines.SitecoreWebservices.MoveToResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class MoveToResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement MoveToResult;
        
        public MoveToResponseBody() {
        }
        
        public MoveToResponseBody(System.Xml.Linq.XElement MoveToResult) {
            this.MoveToResult = MoveToResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveVersion", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.RemoveVersionRequestBody Body;
        
        public RemoveVersionRequest() {
        }
        
        public RemoveVersionRequest(SIM.Pipelines.SitecoreWebservices.RemoveVersionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class RemoveVersionRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string language;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string version;

      public RemoveVersionRequestBody() {
        }
        
        public RemoveVersionRequestBody(string id, string language, string version, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.language = language;
            this.version = version;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveVersionResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.RemoveVersionResponseBody Body;
        
        public RemoveVersionResponse() {
        }
        
        public RemoveVersionResponse(SIM.Pipelines.SitecoreWebservices.RemoveVersionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class RemoveVersionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RemoveVersionResult;
        
        public RemoveVersionResponseBody() {
        }
        
        public RemoveVersionResponseBody(System.Xml.Linq.XElement RemoveVersionResult) {
            this.RemoveVersionResult = RemoveVersionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RenameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Rename", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.RenameRequestBody Body;
        
        public RenameRequest() {
        }
        
        public RenameRequest(SIM.Pipelines.SitecoreWebservices.RenameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class RenameRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
      public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string newName;

      public RenameRequestBody() {
        }
        
        public RenameRequestBody(string id, string newName, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.id = id;
            this.newName = newName;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RenameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RenameResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.RenameResponseBody Body;
        
        public RenameResponse() {
        }
        
        public RenameResponse(SIM.Pipelines.SitecoreWebservices.RenameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class RenameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RenameResult;
        
        public RenameResponseBody() {
        }
        
        public RenameResponseBody(System.Xml.Linq.XElement RenameResult) {
            this.RenameResult = RenameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Save", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.SaveRequestBody Body;
        
        public SaveRequest() {
        }
        
        public SaveRequest(SIM.Pipelines.SitecoreWebservices.SaveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class SaveRequestBody {
      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
      public string databaseName;

      [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
      public string xml;

      public SaveRequestBody() {
        }
        
        public SaveRequestBody(string xml, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.xml = xml;
            this.databaseName = databaseName;
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.SaveResponseBody Body;
        
        public SaveResponse() {
        }
        
        public SaveResponse(SIM.Pipelines.SitecoreWebservices.SaveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class SaveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement SaveResult;
        
        public SaveResponseBody() {
        }
        
        public SaveResponseBody(System.Xml.Linq.XElement SaveResult) {
            this.SaveResult = SaveResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyCredentialsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyCredentials", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequestBody Body;
        
        public VerifyCredentialsRequest() {
        }
        
        public VerifyCredentialsRequest(SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class VerifyCredentialsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SIM.Pipelines.SitecoreWebservices.Credentials credentials;
        
        public VerifyCredentialsRequestBody() {
        }
        
        public VerifyCredentialsRequestBody(SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            this.credentials = credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyCredentialsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyCredentialsResponse", Namespace="http://sitecore.net/visual/", Order=0)]
        public SIM.Pipelines.SitecoreWebservices.VerifyCredentialsResponseBody Body;
        
        public VerifyCredentialsResponse() {
        }
        
        public VerifyCredentialsResponse(SIM.Pipelines.SitecoreWebservices.VerifyCredentialsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/visual/")]
    public partial class VerifyCredentialsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement VerifyCredentialsResult;
        
        public VerifyCredentialsResponseBody() {
        }
        
        public VerifyCredentialsResponseBody(System.Xml.Linq.XElement VerifyCredentialsResult) {
            this.VerifyCredentialsResult = VerifyCredentialsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VisualSitecoreServiceSoapChannel : SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VisualSitecoreServiceSoapClient : System.ServiceModel.ClientBase<SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap>, SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap {
        
        public VisualSitecoreServiceSoapClient() {
        }
        
        public VisualSitecoreServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VisualSitecoreServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VisualSitecoreServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VisualSitecoreServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

      #region VisualSitecoreServiceSoap Members

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.AddFromMasterResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.AddFromMaster(SIM.Pipelines.SitecoreWebservices.AddFromMasterRequest request) {
            return base.Channel.AddFromMaster(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.AddFromTemplateResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.AddFromTemplate(SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequest request) {
            return base.Channel.AddFromTemplate(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.AddVersionResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.AddVersion(SIM.Pipelines.SitecoreWebservices.AddVersionRequest request) {
            return base.Channel.AddVersion(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.CopyToResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.CopyTo(SIM.Pipelines.SitecoreWebservices.CopyToRequest request) {
            return base.Channel.CopyTo(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.DeleteResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.Delete(SIM.Pipelines.SitecoreWebservices.DeleteRequest request) {
            return base.Channel.Delete(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.DeleteChildrenResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.DeleteChildren(SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequest request) {
            return base.Channel.DeleteChildren(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.DuplicateResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.Duplicate(SIM.Pipelines.SitecoreWebservices.DuplicateRequest request) {
            return base.Channel.Duplicate(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetChildrenResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetChildren(SIM.Pipelines.SitecoreWebservices.GetChildrenRequest request) {
            return base.Channel.GetChildren(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetDatabasesResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetDatabases(SIM.Pipelines.SitecoreWebservices.GetDatabasesRequest request) {
            return base.Channel.GetDatabases(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetItemMastersResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetItemMasters(SIM.Pipelines.SitecoreWebservices.GetItemMastersRequest request) {
            return base.Channel.GetItemMasters(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetItemFieldsResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetItemFields(SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequest request) {
            return base.Channel.GetItemFields(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetLanguagesResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetLanguages(SIM.Pipelines.SitecoreWebservices.GetLanguagesRequest request) {
            return base.Channel.GetLanguages(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetMastersResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetMasters(SIM.Pipelines.SitecoreWebservices.GetMastersRequest request) {
            return base.Channel.GetMasters(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetTemplatesResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetTemplates(SIM.Pipelines.SitecoreWebservices.GetTemplatesRequest request) {
            return base.Channel.GetTemplates(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.GetXMLResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.GetXML(SIM.Pipelines.SitecoreWebservices.GetXMLRequest request) {
            return base.Channel.GetXML(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.InsertXMLResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.InsertXML(SIM.Pipelines.SitecoreWebservices.InsertXMLRequest request) {
            return base.Channel.InsertXML(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.MoveToResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.MoveTo(SIM.Pipelines.SitecoreWebservices.MoveToRequest request) {
            return base.Channel.MoveTo(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.RemoveVersionResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.RemoveVersion(SIM.Pipelines.SitecoreWebservices.RemoveVersionRequest request) {
            return base.Channel.RemoveVersion(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.RenameResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.Rename(SIM.Pipelines.SitecoreWebservices.RenameRequest request) {
            return base.Channel.Rename(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.SaveResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.Save(SIM.Pipelines.SitecoreWebservices.SaveRequest request) {
            return base.Channel.Save(request);
        }

      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIM.Pipelines.SitecoreWebservices.VerifyCredentialsResponse SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap.VerifyCredentials(SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequest request) {
            return base.Channel.VerifyCredentials(request);
        }

      #endregion

      public System.Xml.Linq.XElement AddFromMaster(string id, string masterID, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.AddFromMasterRequest inValue = new SIM.Pipelines.SitecoreWebservices.AddFromMasterRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.AddFromMasterRequestBody();
        inValue.Body.id = id;
        inValue.Body.masterID = masterID;
        inValue.Body.name = name;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.AddFromMasterResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).AddFromMaster(inValue);
        return retVal.Body.AddFromMasterResult;
      }

      public System.Xml.Linq.XElement AddFromTemplate(string id, string templateID, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequest inValue = new SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.AddFromTemplateRequestBody();
        inValue.Body.id = id;
        inValue.Body.templateID = templateID;
        inValue.Body.name = name;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.AddFromTemplateResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).AddFromTemplate(inValue);
        return retVal.Body.AddFromTemplateResult;
      }

      public System.Xml.Linq.XElement AddVersion(string id, string language, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.AddVersionRequest inValue = new SIM.Pipelines.SitecoreWebservices.AddVersionRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.AddVersionRequestBody();
        inValue.Body.id = id;
        inValue.Body.language = language;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.AddVersionResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).AddVersion(inValue);
        return retVal.Body.AddVersionResult;
      }

      public System.Xml.Linq.XElement CopyTo(string id, string newParent, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.CopyToRequest inValue = new SIM.Pipelines.SitecoreWebservices.CopyToRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.CopyToRequestBody();
        inValue.Body.id = id;
        inValue.Body.newParent = newParent;
        inValue.Body.name = name;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.CopyToResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).CopyTo(inValue);
        return retVal.Body.CopyToResult;
      }

      public System.Xml.Linq.XElement Delete(string id, bool recycle, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.DeleteRequest inValue = new SIM.Pipelines.SitecoreWebservices.DeleteRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.DeleteRequestBody();
        inValue.Body.id = id;
        inValue.Body.recycle = recycle;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.DeleteResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).Delete(inValue);
        return retVal.Body.DeleteResult;
      }

      public System.Xml.Linq.XElement DeleteChildren(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequest inValue = new SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.DeleteChildrenRequestBody();
        inValue.Body.id = id;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.DeleteChildrenResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).DeleteChildren(inValue);
        return retVal.Body.DeleteChildrenResult;
      }

      public System.Xml.Linq.XElement Duplicate(string id, string name, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.DuplicateRequest inValue = new SIM.Pipelines.SitecoreWebservices.DuplicateRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.DuplicateRequestBody();
        inValue.Body.id = id;
        inValue.Body.name = name;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.DuplicateResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).Duplicate(inValue);
        return retVal.Body.DuplicateResult;
      }

      public System.Xml.Linq.XElement GetChildren(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetChildrenRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetChildrenRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetChildrenRequestBody();
        inValue.Body.id = id;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetChildrenResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetChildren(inValue);
        return retVal.Body.GetChildrenResult;
      }

      public System.Xml.Linq.XElement GetDatabases(SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetDatabasesRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetDatabasesRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetDatabasesRequestBody();
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetDatabasesResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetDatabases(inValue);
        return retVal.Body.GetDatabasesResult;
      }

      public System.Xml.Linq.XElement GetItemMasters(string id, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetItemMastersRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetItemMastersRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetItemMastersRequestBody();
        inValue.Body.id = id;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetItemMastersResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetItemMasters(inValue);
        return retVal.Body.GetItemMastersResult;
      }

      public System.Xml.Linq.XElement GetItemFields(string id, string language, string version, bool allFields, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetItemFieldsRequestBody();
        inValue.Body.id = id;
        inValue.Body.language = language;
        inValue.Body.version = version;
        inValue.Body.allFields = allFields;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetItemFieldsResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetItemFields(inValue);
        return retVal.Body.GetItemFieldsResult;
      }

      public System.Xml.Linq.XElement GetLanguages(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetLanguagesRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetLanguagesRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetLanguagesRequestBody();
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetLanguagesResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetLanguages(inValue);
        return retVal.Body.GetLanguagesResult;
      }

      public System.Xml.Linq.XElement GetMasters(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetMastersRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetMastersRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetMastersRequestBody();
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetMastersResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetMasters(inValue);
        return retVal.Body.GetMastersResult;
      }

      public System.Xml.Linq.XElement GetTemplates(string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetTemplatesRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetTemplatesRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetTemplatesRequestBody();
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetTemplatesResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetTemplates(inValue);
        return retVal.Body.GetTemplatesResult;
      }

      public System.Xml.Linq.XElement GetXML(string id, bool deep, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.GetXMLRequest inValue = new SIM.Pipelines.SitecoreWebservices.GetXMLRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.GetXMLRequestBody();
        inValue.Body.id = id;
        inValue.Body.deep = deep;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.GetXMLResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).GetXML(inValue);
        return retVal.Body.GetXMLResult;
      }

      public System.Xml.Linq.XElement InsertXML(string id, string xml, bool changeIDs, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.InsertXMLRequest inValue = new SIM.Pipelines.SitecoreWebservices.InsertXMLRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.InsertXMLRequestBody();
        inValue.Body.id = id;
        inValue.Body.xml = xml;
        inValue.Body.changeIDs = changeIDs;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.InsertXMLResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).InsertXML(inValue);
        return retVal.Body.InsertXMLResult;
      }

      public System.Xml.Linq.XElement MoveTo(string id, string newParent, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.MoveToRequest inValue = new SIM.Pipelines.SitecoreWebservices.MoveToRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.MoveToRequestBody();
        inValue.Body.id = id;
        inValue.Body.newParent = newParent;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.MoveToResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).MoveTo(inValue);
        return retVal.Body.MoveToResult;
      }

      public System.Xml.Linq.XElement RemoveVersion(string id, string language, string version, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.RemoveVersionRequest inValue = new SIM.Pipelines.SitecoreWebservices.RemoveVersionRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.RemoveVersionRequestBody();
        inValue.Body.id = id;
        inValue.Body.language = language;
        inValue.Body.version = version;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.RemoveVersionResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).RemoveVersion(inValue);
        return retVal.Body.RemoveVersionResult;
      }

      public System.Xml.Linq.XElement Rename(string id, string newName, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.RenameRequest inValue = new SIM.Pipelines.SitecoreWebservices.RenameRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.RenameRequestBody();
        inValue.Body.id = id;
        inValue.Body.newName = newName;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.RenameResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).Rename(inValue);
        return retVal.Body.RenameResult;
      }

      public System.Xml.Linq.XElement Save(string xml, string databaseName, SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
        SIM.Pipelines.SitecoreWebservices.SaveRequest inValue = new SIM.Pipelines.SitecoreWebservices.SaveRequest();
        inValue.Body = new SIM.Pipelines.SitecoreWebservices.SaveRequestBody();
        inValue.Body.xml = xml;
        inValue.Body.databaseName = databaseName;
        inValue.Body.credentials = credentials;
        SIM.Pipelines.SitecoreWebservices.SaveResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).Save(inValue);
        return retVal.Body.SaveResult;
      }

      public System.Xml.Linq.XElement VerifyCredentials(SIM.Pipelines.SitecoreWebservices.Credentials credentials) {
            SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequest inValue = new SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequest();
            inValue.Body = new SIM.Pipelines.SitecoreWebservices.VerifyCredentialsRequestBody();
            inValue.Body.credentials = credentials;
            SIM.Pipelines.SitecoreWebservices.VerifyCredentialsResponse retVal = ((SIM.Pipelines.SitecoreWebservices.VisualSitecoreServiceSoap)(this)).VerifyCredentials(inValue);
            return retVal.Body.VerifyCredentialsResult;
        }
    }
}
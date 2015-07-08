﻿using System.Windows;
using SIM.Instances;
using SIM.Tool.Base;
using SIM.Tool.Base.Plugins;
using SIM.Tool.Base.Runtime;
using SIM.Tool.Windows.Dialogs;

namespace SIM.Tool.Windows.MainWindowComponents
{
  public class SettingsButton : IMainWindowButton
  {
    public bool IsEnabled(Window mainWindow, Instance instance)
    {
      return true;
    }

    public void OnClick(Window mainWindow, Instance instance)
    {
      WindowHelper.ShowDialog<SettingsDialog>(null, mainWindow);
      if (!LifeManager.IsRestarting)
        MainWindowHelper.Initialize();
    }
  }
}
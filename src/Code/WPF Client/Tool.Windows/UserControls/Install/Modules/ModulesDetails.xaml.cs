﻿#region Usings

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SIM.Base;
using SIM.Products;
using SIM.Tool.Base;
using SIM.Tool.Base.Pipelines;
using SIM.Tool.Base.Wizards;
using Product = SIM.Products.Product;

#endregion

namespace SIM.Tool.Windows.UserControls.Install.Modules
{
  using System.IO;
  using Base.Profiles;
  using Microsoft.Win32;

  /// <summary>
  ///   Interaction logic for ModulesDetails.xaml
  /// </summary>
  public partial class ModulesDetails : IWizardStep, ICustomButton
  {
    #region Fields

    /// <summary>
    ///   is set on UserControlLoaded
    /// </summary>
    private ObservableCollection<ProductInCheckbox> productFamilies = new ObservableCollection<ProductInCheckbox>();
    private ObservableCollection<ProductInCheckbox> unfilteredProductFamilies = new ObservableCollection<ProductInCheckbox>();
    
    private bool isProductFamiliesChanged;

    #endregion

    #region Constructors

    /// <summary>
    ///   Initializes a new instance of the <see cref="ModulesDetails" /> class.
    /// </summary>
    public ModulesDetails()
    {
      this.InitializeComponent();
      this.sitecoreModules.ItemsSource = this.productFamilies;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Modules the selected.
    /// </summary>
    /// <param name="sender">
    /// The sender. 
    /// </param>
    /// <param name="e">
    /// The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data. 
    /// </param>
    private void ModuleSelected([CanBeNull] object sender, [CanBeNull] SelectionChangedEventArgs e)
    {
      this.sitecoreModules.SelectedIndex = -1;
    }

    #region Search Implementation

    private void SearchTextBoxKeyPressed(object sender, KeyEventArgs e)
    {
      try
      {
        Assert.ArgumentNotNull(e, "e");

        if (e.Handled)
          return;
        e.Handled = true;
        Key key = e.Key;

        if (key == Key.Escape)
        {
          this.SearchTextBox.Text = string.Empty;
        }

        DoSearch(this.SearchTextBox.Text);
      }
      catch (Exception ex)
      {
        WindowHelper.HandleError(ex.Message, true, ex, this);
      }
    }

    private void Search(object sender, RoutedEventArgs e)
    {
      DoSearch(this.SearchTextBox.Text);
    }

    private void DoSearch(string filter)
    {
      this.productFamilies = new ObservableCollection<ProductInCheckbox>(this.unfilteredProductFamilies.Where(product => product.Name.ContainsIgnoreCase(filter) || product.Value.SearchToken.ContainsIgnoreCase(filter)));
      this.sitecoreModules.ItemsSource = this.productFamilies;
    }

    #endregion

    #endregion

    #region IWizardStep Members

    void IWizardStep.InitializeStep(WizardArgs wizardArgs)
    {
      var args = (InstallModulesWizardArgs)wizardArgs;

      // create new checkbox list
      Product instanceProduct = args.Product;
      if (instanceProduct == null)
      {
        return;
      }
      var modules = ProductManager.Modules.Where(m => m.IsMatchRequirements(instanceProduct)).OrderByDescending(m => m.SortOrder);
      IEnumerable<string> moduleNames = modules.GroupBy(module => module.Name).Select(moduleGroup => moduleGroup.Key);
      ProductInCheckbox[] productCheckboxes = moduleNames.Select(moduleName => new ProductInCheckbox(moduleName, modules.Where(module => module.Name.EqualsIgnoreCase(moduleName)).OrderByDescending(m => m.VersionAndRevision).ToArray())).ToArray();

      this.productFamilies = new ObservableCollection<ProductInCheckbox>(productCheckboxes);
      this.unfilteredProductFamilies = new ObservableCollection<ProductInCheckbox>(productCheckboxes);

      foreach (Product module in args.Modules)
      {
        Product alreadySelectedModule = module;
        ProductInCheckbox checkBoxItem = productCheckboxes.SingleOrDefault(cbi => cbi.Name.Equals(alreadySelectedModule.Name, StringComparison.OrdinalIgnoreCase));
        if (checkBoxItem != null)
        {
          checkBoxItem.IsChecked = checkBoxItem.Name == module.Name || module.Name.EqualsIgnoreCase("Sitecore Analytics");
          checkBoxItem.Value = module;
        }
      }

      DoSearch(this.SearchTextBox.Text = string.Empty);
      this.sitecoreModules.ItemsSource = this.productFamilies;
    }

    bool IWizardStep.SaveChanges(WizardArgs wizardArgs)
    {
      var args = (InstallModulesWizardArgs)wizardArgs;
      Product product = args.Product;
      Assert.IsNotNull(product, "product");
      Product[] selectedModules = this.unfilteredProductFamilies.Where(mm => mm.IsChecked).Select(mm => mm.Value).ToArray();
      args.Modules.AddRange(selectedModules.Where(module => !args.Modules.Any(p => p.Name.Equals(module.Name, StringComparison.OrdinalIgnoreCase))));

      return true;
    }

    #endregion

    public string CustomButtonText
    {
      get
      {
        return "Add Module";
      }
    }
    public void CustomButtonClick()
    {
      var openDialog = new OpenFileDialog
      {
        CheckFileExists = true,
        Filter = "Sitecore Package or ZIP Archive (*.zip)|*.zip",
        Title = "Choose Package",
        Multiselect = true
      };

      if (openDialog.ShowDialog(Window.GetWindow(this)) != true) return;
      
      foreach (var path in openDialog.FileNames)
      {
        var fileName = Path.GetFileName(path);

        if (string.IsNullOrEmpty(fileName)) continue;

        List<ProductInCheckbox> products = null;
        Product addedProduct;
        
        Product.TryParse(path, out addedProduct);

        if (addedProduct == null || string.IsNullOrEmpty(addedProduct.Name) || string.IsNullOrEmpty(addedProduct.Version) || string.IsNullOrEmpty(addedProduct.Revision))
        {
          WindowHelper.ShowMessage("Selected file is not a Sitecore module package");
          return;
        }

        var family = GetProductFamily(addedProduct.OriginalName);

        if (family == null)
        {
          FileSystem.Local.File.Copy(path, Path.Combine(ProfileManager.Profile.LocalRepository, fileName));
          
          Product.TryParse(Path.Combine(ProfileManager.Profile.LocalRepository, fileName), out addedProduct);
          products = this.productFamilies.ToList();
          products.Add(family = new ProductInCheckbox(addedProduct.Name, new[] { addedProduct }));
          
          isProductFamiliesChanged = true;
        }
        else
        {
          var product = GetProduct(family, addedProduct);
            
          if (product == null)
          {
            var location = FileSystem.Local.Directory.GetParent(family.Scope.FirstOrDefault().IsNotNull().PackagePath).FullName;
            FileSystem.Local.File.Copy(path, Path.Combine(location, fileName));
            Product.TryParse(Path.Combine(location, fileName), out addedProduct);

            products = this.productFamilies.Where(item => !item.Name.Equals(family.Name, StringComparison.InvariantCultureIgnoreCase)).ToList();
            products.Insert(productFamilies.IndexOf(family), family = new ProductInCheckbox(family.Name, family.Scope.Add(addedProduct).ToArray()));

            isProductFamiliesChanged = true;
          }
          else
          {
            var location = FileSystem.Local.Directory.GetParent(product.PackagePath).FullName;      
            FileSystem.Local.File.DeleteIfExists(product.PackagePath);
            FileSystem.Local.File.Copy(path, Path.Combine(location, fileName));
            addedProduct = product;
          }
        }

        ProductManager.Initialize(ProfileManager.Profile.LocalRepository);
        SelectAddedPackage(family, addedProduct);

        if (isProductFamiliesChanged) RefreshDataSource(products);
      }
    }

    private ProductInCheckbox GetProductFamily(string originalName)
    {
      return productFamilies.FirstOrDefault(productInCheckbox => productInCheckbox.Scope.FirstOrDefault().IsNotNull().OriginalName.Equals(originalName, StringComparison.InvariantCultureIgnoreCase));
    }

    private static Product GetProduct(ProductInCheckbox module, Product product)
    {
      return module.Scope.FirstOrDefault(version => version.Version.Equals(product.Version, StringComparison.InvariantCultureIgnoreCase) && version.Revision.Equals(product.Revision, StringComparison.InvariantCultureIgnoreCase));
    }

    private void RefreshDataSource(List<ProductInCheckbox> products)
    {
      this.productFamilies = new ObservableCollection<ProductInCheckbox>(products);
      this.unfilteredProductFamilies = new ObservableCollection<ProductInCheckbox>(products);
      this.sitecoreModules.ItemsSource = this.productFamilies;

      isProductFamiliesChanged = false;
    }

    private void SelectAddedPackage(ProductInCheckbox family, Product product)
    {
      family.IsChecked = true;
      family.Value = product;
    }
  }
}
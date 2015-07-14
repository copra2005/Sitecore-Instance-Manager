﻿namespace SIM.Tests.Pipelines
{
  using System.IO;
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using SIM.Products;

  [TestClass]
  public class ProductTests
  {
    #region Public methods

    [TestMethod]
    public void ProductTestEcm21Rev130731()
    {
      var path = Path.GetFileName(@"..\..\..\..\Tests\Tests\TestData\Products\sitecore 6.6.0\modules\email campaign manager\2.1 rev. 131007\e-mail campaign manager 2.1. rev. 130731.zip");

      var actual = Product.ProductRegex.IsMatch(path);
      var expected = true;
      TestHelper.AreEqual(actual.ToString(), expected.ToString(), @"The following file was{0} considered as file, where is must{1} be
{2}".FormatWith(expected ? " NOT" : string.Empty, expected ? string.Empty : " NOT", path));
    }

    [TestMethod]
    public void ProductTestEcm21Rev131007()
    {
      var path = Path.GetFileName(@"..\..\..\..\Tests\Tests\TestData\Products\sitecore 6.6.0\modules\email campaign manager\2.1 rev. 131007\e-mail campaign manager 2.1 rev. 131007.zip");
      var actual = Product.ProductRegex.IsMatch(path);
      var expected = true;
      TestHelper.AreEqual(actual.ToString(), expected.ToString(), @"The following file was{0} considered as file, where is must{1} be
{2}".FormatWith(expected ? " NOT" : string.Empty, expected ? string.Empty : " NOT", path));
    }

    #endregion
  }
}
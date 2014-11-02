using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Tests
{
  [TestClass]
  public class ModuleCatalogTests
  {
    [TestMethod]
    public void ModuleRegisterSuccess()
    {
      var module = new Mock<IModuleInfo>();
      var target = new ModuleCatalog();
      target.RegisterModule(module.Object);
      Assert.IsTrue(target.Any());
    }

    [TestMethod]
    [ExpectedException(typeof (ArgumentNullException))]
    public void ModuleRegisterFail_InvalidModuleReference()
    {
      IModuleInfo module = null;
      var target = new ModuleCatalog();
      target.RegisterModule(module);
    }
  }
}

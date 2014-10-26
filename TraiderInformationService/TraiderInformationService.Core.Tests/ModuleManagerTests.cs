using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Tests
{
  [TestClass]
  public class ModuleManagerTests
  {
    [TestMethod]
    public void ModulesInitializeSuccess()
    {
      var mockRepository = new MockRepository(MockBehavior.Default);
      var moduleCalalog = mockRepository.Create<IModuleCatalog>();
      var mockModule = mockRepository.Create<IModule>();
      
      mockModule.Setup(t => t.Initialize());
      moduleCalalog.Setup(t => t.GetEnumerator())
        .Returns(new List<IModule> {mockModule.Object}.GetEnumerator());
      var target = new ModuleManager();

      target.InitializeModules(moduleCalalog.Object);

      mockModule.Verify();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ModulesInitializeFailInvalidCatalog()
    {
      IModuleCatalog invalidCatalog = null;
      var target = new ModuleManager();
      target.InitializeModules(invalidCatalog);
    }
  }
}

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
      var mockModuleInitializer = mockRepository.Create<IModuleInitializer>();
      
      mockModuleInitializer.Setup(t => t.IntializeModule(It.IsAny<IModuleInfo>()));
      moduleCalalog.Setup(t => t.GetEnumerator())
        .Returns(new List<IModuleInfo> { It.IsAny<IModuleInfo>() }.GetEnumerator());
      var target = new ModuleManager(mockModuleInitializer.Object);

      target.InitializeModules(moduleCalalog.Object);

      mockModuleInitializer.Verify();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ModulesInitializeFailInvalidCatalog()
    {
      IModuleCatalog invalidCatalog = null;
      var mockModuleInitializer = new Mock<IModuleInitializer>();
      var target = new ModuleManager(mockModuleInitializer.Object);
      target.InitializeModules(invalidCatalog);
    }
  }
}

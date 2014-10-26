using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Tests
{
  [TestClass]
  public class ModularityApplicationManagerTests
  {
    [TestMethod]
    public void SuccesedConfiguration()
    {
      var mockRepository = new MockRepository(MockBehavior.Default);
      var mockModuleManager = mockRepository.Create<IModuleManager>();
      var mockModuleCatalog = mockRepository.Create<IModuleCatalog>();
      var target = mockRepository.Create<ModularityApplicationManager>(mockModuleCatalog.Object, mockModuleManager.Object);
      mockModuleManager.Setup(t => t.InitializeModules(mockModuleCatalog.Object));
      
      target.Object.ConfigureApplication();

      mockRepository.Verify();
    }
  }
}

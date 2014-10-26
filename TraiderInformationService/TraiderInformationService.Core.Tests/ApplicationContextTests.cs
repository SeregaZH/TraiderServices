using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TraiderInformationService.Core.Application;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Tests
{
  [TestClass]
  public class ApplicationContextTests
  {
    [TestMethod]
    public void ApplicationModeSetted()
    {
      const string testUriPrefix = "test";
      const ApplicationModes testName = ApplicationModes.Dev;
      var testConfigElement = new ApplicationModeElement
      {
        IsActive = true,
        UriPrefix = testUriPrefix,
        Name = testName
      };

      var mockConfigurationManager = new Mock<IConfigurationManager>();
      mockConfigurationManager.Setup(t => t.GetActiveMode()).Returns(testConfigElement);
      var target = new ApplicationContext(mockConfigurationManager.Object);

      var result = target.Mode;

      Assert.IsNotNull(result);
      Assert.AreEqual(testUriPrefix, result.ViewUriPrefix);
      Assert.AreEqual(testName, result.Name);
      mockConfigurationManager.Verify(t => t.GetActiveMode(), Times.Once());
    }
  }
}

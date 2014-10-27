using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TraiderInformationService.Core.Application;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;
using TraiderInformationService.Core.Interfaces.Mapper;

namespace TraiderInformationService.Core.Tests
{
  [TestClass]
  public class ApplicationContextTests
  {
    [TestMethod]
    public void ApplicationModeSetted()
    {
      var mockRepository = new MockRepository(MockBehavior.Default);
      var mockConfigurationManager = mockRepository.Create<IConfigurationManager>();
      var mockMapperFactory = mockRepository.Create<IMapperFactory>();
      var mockMapper = mockRepository.Create<IMapper>();
      mockConfigurationManager
        .Setup(t => t.GetActiveMode())
        .Returns(It.IsAny<ApplicationModeElement>());
      mockMapperFactory
        .Setup(t => t.CreateMapper(It.IsAny<Profile>()))
        .Returns(mockMapper.Object);
      mockMapper
        .Setup(t => t.Map<ApplicationModeElement, IApplicationMode>(It.IsAny<ApplicationModeElement>()))
        .Returns(new ApplicationModeWrapper());
      
      var target = new ApplicationContext(mockConfigurationManager.Object, mockMapperFactory.Object);

      var result = target.Mode;

      Assert.IsNotNull(result);
      mockRepository.Verify();
    }
  }
}

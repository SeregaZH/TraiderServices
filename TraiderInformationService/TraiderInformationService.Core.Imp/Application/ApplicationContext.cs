using System;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;
using TraiderInformationService.Core.Interfaces.Mapper;
using TraiderInformationService.Core.Mapping.Profiles;

namespace TraiderInformationService.Core.Application
{
  public class ApplicationContext : IApplicationContext
  {
    private Lazy<IApplicationMode> _applicationMode;
    private readonly IConfigurationManager _configurationManager;
    private readonly IMapperFactory _mapperFactory;

    public ApplicationContext(
      IConfigurationManager configurationManager, 
      IMapperFactory mapperFactory)
    {
      _configurationManager = configurationManager;
      _mapperFactory = mapperFactory;
      Init();
    }

    public IApplicationMode Mode
    {
      get
      {
        return _applicationMode.Value;
      }
    }

    private void Init()
    {
      _applicationMode = new Lazy<IApplicationMode>(InitializeMode);
    }

    private IApplicationMode InitializeMode()
    {
      ApplicationModeElement configurationElement = _configurationManager.GetActiveMode();
      IMapper mapper = _mapperFactory.CreateMapper(new CoreProfile());
      return mapper.Map<ApplicationModeElement, IApplicationMode>(configurationElement);
    }
  }
}

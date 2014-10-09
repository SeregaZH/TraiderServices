using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;
using TraiderInformationService.Core.Interfaces.Mapper;

namespace TraiderInformationService.Core.Mapping.Profiles
{
  public class CoreProfile : ProfileBase
  {
    protected override void Configure()
    {
      AutoMapper.Mapper.CreateMap<ApplicationModeElement, ApplicationMode>();
      base.Configure();
    }
  }
}

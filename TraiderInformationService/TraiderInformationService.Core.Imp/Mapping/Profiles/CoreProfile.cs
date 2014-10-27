using TraiderInformationService.Core.Application;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;
using TraiderInformationService.Core.Interfaces.Mapper;
using TraiderInformationService.Core.Mapping.ValueResolvers;

namespace TraiderInformationService.Core.Mapping.Profiles
{
  public class CoreProfile : ProfileBase
  {
    protected override void Configure()
    {
      AutoMapper.Mapper
        .CreateMap<ApplicationModeElement, ApplicationMode>()
        .ForMember(dst => dst.Name, opt => opt.ResolveUsing(new ModeNameValueResolver())
          .FromMember(src => src.Name))
        .ForMember(dst => dst.ViewUriPrefix, opt => opt.MapFrom(src => src.UriPrefix));
      
      AutoMapper.Mapper
        .CreateMap<ApplicationModeElement, IApplicationMode>()
        .ConstructUsing(context => new ApplicationModeWrapper(AutoMapper.Mapper.
          Map<ApplicationMode>(context.SourceValue)));

      base.Configure();
    }
  }
}

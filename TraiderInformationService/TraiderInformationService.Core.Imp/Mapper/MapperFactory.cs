using AutoMapper;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Mapper;

namespace TraiderInformationService.Core.Imp.Mapper
{
  public class MapperFactory : IMapperFactory
  {
    public IMapper CreateMapper<TProfile>(TProfile profile) 
      where TProfile : Profile
    {
      return new MapperWrapper<TProfile>(profile);
    }
  }
}

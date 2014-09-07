using AutoMapper;
using TraiderInformationService.Core.Interfaces.Mapper;

namespace TraiderInformationService.Core.Interfaces
{
  public interface IMapperFactory
  {
    IMapper CreateMapper<TProfile>(TProfile profile) 
      where TProfile : Profile;
  }
}

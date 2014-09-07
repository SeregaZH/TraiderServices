using AutoMapper;

namespace TraiderInformationService.Core.Interfaces.Mapper
{
  public class ProfileBase : Profile
  {
    public ProfileBase()
    {
      AutoMapper.Mapper.Reset();
    }
  }
}

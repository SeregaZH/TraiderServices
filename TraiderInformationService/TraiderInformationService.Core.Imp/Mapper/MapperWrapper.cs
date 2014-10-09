using System;
using AutoMapper;
using TraiderInformationService.Core.Interfaces.Mapper;

namespace TraiderInformationService.Core.Mapper
{
  public class MapperWrapper<TProfile> : IMapper
    where TProfile : Profile
  {
    public MapperWrapper(TProfile profile)
    {
      AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile(profile));
    }

    public TDestination Map<TDestination>(object source)
    {
      return AutoMapper.Mapper.Map<TDestination>(source);
    }

    public TDestination Map<TDestination>(object source, Action<IMappingOperationOptions> opts)
    {
      return AutoMapper.Mapper.Map<TDestination>(source, opts);
    }

    public TDestination Map<TSource, TDestination>(TSource source)
    {
      return AutoMapper.Mapper.Map<TSource, TDestination>(source);
    }

    public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
    {
      return AutoMapper.Mapper.Map(source, destination);
    }

    public TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<IMappingOperationOptions> opts)
    {
      return AutoMapper.Mapper.Map(source, destination, opts);
    }

    public TDestination Map<TSource, TDestination>(TSource source, Action<IMappingOperationOptions> opts)
    {
      return AutoMapper.Mapper.Map<TSource, TDestination>(source, opts);
    }

    public object Map(object source, Type sourceType, Type destinationType)
    {
      return AutoMapper.Mapper.Map(source, sourceType, destinationType);
    }

    public object Map(object source, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts)
    {
      return AutoMapper.Mapper.Map(source, sourceType, destinationType, opts);
    }

    public object Map(object source, object destination, Type sourceType, Type destinationType)
    {
      return AutoMapper.Mapper.Map(source, destination, sourceType, destinationType);
    }

    public object Map(object source, object destination, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts)
    {
      return AutoMapper.Mapper.Map(source, destination, sourceType, destinationType, opts);
    }

    public TDestination DynamicMap<TSource, TDestination>(TSource source)
    {
      return AutoMapper.Mapper.DynamicMap<TSource, TDestination>(source);
    }

    public void DynamicMap<TSource, TDestination>(TSource source, TDestination destination)
    {
      AutoMapper.Mapper.DynamicMap(source, destination);
    }

    public TDestination DynamicMap<TDestination>(object source)
    {
      return AutoMapper.Mapper.DynamicMap<TDestination>(source);
    }

    public object DynamicMap(object source, Type sourceType, Type destinationType)
    {
      return AutoMapper.Mapper.DynamicMap(source, sourceType, destinationType);
    }

    public void DynamicMap(object source, object destination, Type sourceType, Type destinationType)
    {
      AutoMapper.Mapper.DynamicMap(source, destination,sourceType, destinationType);
    }
  }
}

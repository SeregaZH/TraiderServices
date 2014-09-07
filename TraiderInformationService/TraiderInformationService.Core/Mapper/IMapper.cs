﻿using System;
using AutoMapper;

namespace TraiderInformationService.Core.Interfaces.Mapper
{
  public interface IMapper
  {
    TDestination Map<TDestination>(object source);
    TDestination Map<TDestination>(object source, Action<IMappingOperationOptions> opts);
    TDestination Map<TSource, TDestination>(TSource source);
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<IMappingOperationOptions> opts);
    TDestination Map<TSource, TDestination>(TSource source, Action<IMappingOperationOptions> opts);
    object Map(object source, Type sourceType, Type destinationType);
    object Map(object source, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts);
    object Map(object source, object destination, Type sourceType, Type destinationType);
    object Map(object source, object destination, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts);
    TDestination DynamicMap<TSource, TDestination>(TSource source);
    void DynamicMap<TSource, TDestination>(TSource source, TDestination destination);
    TDestination DynamicMap<TDestination>(object source);
    object DynamicMap(object source, Type sourceType, Type destinationType);
    void DynamicMap(object source, object destination, Type sourceType, Type destinationType);
  }
}

using System;
using AutoMapper;
using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Mapping.ValueResolvers
{
  public sealed class ModeNameValueResolver : ValueResolver<string, ApplicationModes>
  {
    protected override ApplicationModes ResolveCore(string source)
    {
      if (source == null)
      {
        throw new ArgumentNullException("source");
      }

      ApplicationModes result;

      if (!Enum.TryParse(source, true, out result))
      {
        throw new InvalidCastException(string.Format("invalid cast string '{0}' to ApplicationModes enum", source));
      }

      return result;
    }
  }
}

using System;
using TraiderInformationService.Core.Interfaces.DataAccess;
using TraiderInformationService.Data.Model.Interfaces;

namespace TraiderInformationService.Data.Security.Interfaces
{
  public interface IClaimRepository : IReadRepository<Guid, IClaimDto>
  {

  }
}

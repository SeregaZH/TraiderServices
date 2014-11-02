using System;

namespace TraiderInformationService.Data.Model.Interfaces
{
  public interface IClaimDto
  {
    Guid Id { get; set; }
    string Value { get; set; }
    int? Identity { get; set; }
    Guid ClaimTypeId { get; set; }
    int ClaimTypeNumber { get; set; }
    Guid UserId { get; set; }
  }
}

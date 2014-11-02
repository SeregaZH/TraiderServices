using System;
using TraiderInformationService.Data.Model.Interfaces;

namespace TraiderInformationService.Data.Model.Security
{
  public sealed class ClaimDto : IClaimDto
  {
    public Guid Id { get; set; }
    public string Value { get; set; }
    public int? Identity { get; set; }
    public Guid ClaimTypeId { get; set; }
    public int ClaimTypeNumber { get; set; }
    public Guid UserId { get; set; }
  }
}

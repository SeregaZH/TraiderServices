using System;

namespace TraiderInformationService.Model.Interfaces
{
  public interface IClaim
  {
    Guid Id { get; set; }
    string Value { get; set; }
    int? Identity { get; set; }
  }
}

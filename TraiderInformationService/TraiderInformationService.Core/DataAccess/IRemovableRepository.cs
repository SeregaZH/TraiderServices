namespace TraiderInformationService.Core.Interfaces.DataAccess
{
  public interface IRemovableRepository<in TId>
  {
    void Delete(TId id);
  }
}

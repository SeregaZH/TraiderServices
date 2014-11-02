namespace TraiderInformationService.Core.Interfaces.DataAccess
{
  public interface IReadRepository<in TId, out TEntity>
  {
    TEntity GetEntity(TId id);
  }
}

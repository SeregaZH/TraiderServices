namespace TraiderInformationService.Core.Interfaces.DataAccess
{
  public interface IModifyRepository<in TEntity>
  {
    void Create(TEntity entity);
    void Update(TEntity entity);
  }
}

namespace TraiderInformationService.Core.Bootstrap
{
  public abstract class Bootstrapper
  {
    protected abstract void ConfigureServiceLocator();
    protected abstract void ConfigureApplication();
    
    public void Bootstrap() 
    {
      ConfigureServiceLocator();
      ConfigureApplication();
    }
  }
}

using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class UnityModuleCreator : IModuleCreator
  {
    private readonly IUnityContainer _unityContainer;

    public UnityModuleCreator(IUnityContainer unityContainer)
    {
      _unityContainer = unityContainer;
    }

    public IModule Create(IModuleInfo moduleInfo)
    {
      return (IModule)_unityContainer.Resolve(moduleInfo.ModuleType);
    }
  }
}

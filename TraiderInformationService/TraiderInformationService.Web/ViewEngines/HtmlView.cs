using System.IO;
using System.Web.Mvc;

namespace TraiderInformationService.Web.ViewEngines
{
  public class HtmlView : IView
  {
    private readonly string _viewPhysicalPath;
    
    public HtmlView(string viewPhysicalPath)
    {
      _viewPhysicalPath = viewPhysicalPath;
    }

    public void Render(ViewContext viewContext, TextWriter writer)
    {
      string rawContent = File.ReadAllText(_viewPhysicalPath);
      writer.Write(rawContent);
    }
  }
}
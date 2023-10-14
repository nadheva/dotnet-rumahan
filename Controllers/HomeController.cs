using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace netproject1.Controllers;

public class HomeController : Controller 
{
  public string Index()
  {
    return "Hi, its me dave!";
  }

  public string Welcome(string name, int numTimes = 1)
  {
      return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
  }
}
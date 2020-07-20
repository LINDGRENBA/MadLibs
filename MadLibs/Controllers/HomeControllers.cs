using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string MadLib() { return "Soon there will be a madlib story here.";}

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string name1) 
    {
      StoryVariable newStory = new StoryVariable();
      newStory.Person = name1;
      return View(newStory); 
    }
  }
}
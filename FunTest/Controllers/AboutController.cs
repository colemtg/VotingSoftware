using Microsoft.AspNetCore.Mvc;
using System;
namespace VotingSoftware.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Index view
        }
        public IActionResult TellMeMore(string id="")
        {
            return Content($"You asked me about {id}");
            //return View(); //Index view
        }
    }

}

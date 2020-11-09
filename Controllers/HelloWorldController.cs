using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            Movie movie = new Movie();
            movie.Title = "dasa";
            ViewData["Message"] = "Hello " + movie.Title;
            ViewData["NumTimes"] = numTimes;
           
            int a= 12;
            return View(a);
        }
    }
}
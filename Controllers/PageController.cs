using Microsoft.AspNetCore.Mvc;

namespace AspKT1.Controllers
{
    [Route("Page")]
    public class PageController : Controller
    {
        [HttpGet("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

        [HttpGet("Greet/{name}")]
        public IActionResult Greet(string name)
        {
            return View(model: name);
        }


        [HttpGet("Edit")]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost("Result")]
        public IActionResult Result(string message)
        {
            return View(model: message);
        }
    }
}

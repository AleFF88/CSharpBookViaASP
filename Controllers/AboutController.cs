using CSharpBookViaASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBookViaASP.Controllers {
    public class AboutController : Controller {
        public IActionResult About() {
            return View();
        }

        [HttpPost]
        public IActionResult Check(AboutModel input) {
            if (ModelState.IsValid) {
                Console.Beep();
            }
            Console.Beep(1000, 1000);


            return View("About");
        }
    }
}

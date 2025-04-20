using Microsoft.AspNetCore.Mvc;

namespace CSharpBookViaASP.Controllers {
    public class AboutController : Controller {
        public IActionResult About() {
            return View();
        }
    }
}

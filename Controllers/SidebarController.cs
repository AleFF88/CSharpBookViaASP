using Microsoft.AspNetCore.Mvc;

namespace CSharpBookViaASP.Controllers {
    public class SidebarController : Controller {

        public IActionResult Arrays() {
            ViewData["Message"] = "Это Arrays из SidebarController.";
            return View("~/Views/Sidebar/Arrays/Arrays.cshtml");
        }
        public IActionResult NewArticle() {
            ViewData["Message"] = "Это NewArticle из SidebarController.";
            return View();
        }
    }
}

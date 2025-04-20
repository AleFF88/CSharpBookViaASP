using Microsoft.AspNetCore.Mvc;

namespace CSharpBookViaASP.Controllers {
    public class SidebarController : Controller {

        public IActionResult Arrays() {
            ViewData["Message"] = "Это Arrays из SidebarController.";
            return View();
        }
        public IActionResult NewArticle() {
            ViewData["Message"] = "Это NewArticle из SidebarController.";
            return View();
        }
    }
}

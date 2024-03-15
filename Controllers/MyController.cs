using Microsoft.AspNetCore.Mvc;

namespace s1110834035_App.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            string y = DateTime.Now.ToString();
            ViewData["NY"] = y;
            bool isLeapY = DateTime.IsLeapYear(DateTime.Now.Year);
            if (isLeapY)
            {
                ViewData["LY"] = "今年是閏年";
            }
            else
            {
                ViewData["LY"] = "今年是平年";
            }

            return View();
        }

        public ContentResult Intro()
        {

            string s = "<h1>1110834035<br>蔣天誠</h1>";

            return Content(s, "text/html", System.Text.Encoding.UTF8);
        }

        public IActionResult Link()
        {

            return Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        public ActionResult Msg()
        {

            string[] A = { "1", "均銘", "100" };
            string[] B = { "2", "揚凱", "99" };
            string[] C = { "3", "文德", "80" };
            ViewBag.studA = A;
            ViewBag.studB = B;
            ViewBag.studC = C;

            return View("~/Views/My/Msg.cshtml");
        }


        public ActionResult Bs(){
            return View("~/Views/My/Bs.cshtml");
        }
    }
}

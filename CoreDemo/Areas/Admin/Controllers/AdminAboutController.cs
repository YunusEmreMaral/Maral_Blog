using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAboutController : Controller
    {
        Context c=new Context();

        [HttpGet]
        public IActionResult AdminAbout()
        {
             var about=c.Abouts.FirstOrDefault();
             return View(about);
        }
        [HttpPost]
        public IActionResult AdminAbout(About p)
        {

            p.AboutImage1 = "1";
            p.AboutImage2 = "2";
            p.AboutDetails2 = "3";
            c.Abouts.Add(p);
            c.SaveChanges();
            return RedirectToAction("AdminAbout", "AdminAbout");
        }
    }
}

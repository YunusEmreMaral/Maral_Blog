using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminNotificationController : Controller
    {
        NotificationManager nm=new NotificationManager(new EFNotificationRepository());

        public IActionResult Index()
        { 
            var values=nm.GetList();
            return View(values);
        }
    }
}

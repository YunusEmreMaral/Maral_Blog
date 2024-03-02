using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
		public IActionResult ContactDelete(int id)
		{
			var contactvalue = cm.GetById(id);
			cm.TDelete(contactvalue);
			return RedirectToAction("Index", "AdminContact");
		}
	}
}

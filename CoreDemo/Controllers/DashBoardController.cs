﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
	public class DashBoardController : Controller
	{
		public IActionResult Index()
		{
            Context c = new Context();
            var userName = User.Identity.Name;  // bu 3 veri bize  gerekli olan kısım  eşleştirmeyi tyapıyor bunlar !!
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerid = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == writerid).Count();
            ViewBag.v3 = c.Categories.Count();
            ViewBag.v4 = userName;
            return View();
        }
		
	}
}

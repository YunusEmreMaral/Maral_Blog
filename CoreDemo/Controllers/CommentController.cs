using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public IActionResult PartialAddComment(Comment p)
		{
			p.CommentDate = DateTime.Now;
			p.CommentStatus = true;
			p.BlogID = Convert.ToInt32(Request.Form["BlogID"]); // BlogID'yi form verilerinden al
			cm.CommentAdd(p);

			return PartialView();
		}


		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetCommentById(id);
			return PartialView(values);
		}

	}
}
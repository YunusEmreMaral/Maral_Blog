using BusinessLayer.Concrete;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        BlogManager cm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {

			var blogs = cm.GetBlogListWithCategory(); // Tüm blogları veritabanından alın
			var categories = blogs.GroupBy(b => b.CategoryID) // Kategorilere göre gruplayın
								  .Select(g => new CategoryClass
								  {
									  CategoryName = g.FirstOrDefault().Category.CategoryName,
									  CategoryCount = g.Count()
								  }) // Her kategorinin blog sayısını hesaplayın
								  .ToList();

			return Json(categories);

		}
	}
}

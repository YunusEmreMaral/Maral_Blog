using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = cm.GetCommentListWithBlog();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values=cm.GetCommentById(id);  
            cm.CommentDelete(values);
            return RedirectToAction("Index","AdminComment");

        }
        [HttpGet]
        public IActionResult EditComment(int id)
        {
            var values = cm.GetCommentById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditComment(Comment c)
        {
            cm.CommentUpdate(c);
            return RedirectToAction("Index", "AdminComment");
        }
    }
}

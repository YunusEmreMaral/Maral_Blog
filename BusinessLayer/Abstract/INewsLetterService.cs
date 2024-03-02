using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface INewsLetterService
	{
		void NewsLetterAdd(NewsLetter newsletter);
		void NewsLetterDelete(NewsLetter newsletter);
		void NewsLetterUpdate(Writer newsletter);
		List<NewsLetter> GetAllNewsLetter();
		NewsLetter GetById(int id);
		List<NewsLetter> GetBlogListWithwriter();
	}
}

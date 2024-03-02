using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}

		public List<NewsLetter> GetAllNewsLetter()
		{
			return _newsLetterDal.GetListAll();
		}

		public List<NewsLetter> GetBlogListWithwriter()
		{
			throw new NotImplementedException();
		}

		public NewsLetter GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void NewsLetterAdd(NewsLetter newsletter)
		{
			_newsLetterDal.Insert(newsletter);	
		}

		public void NewsLetterDelete(NewsLetter newsletter)
		{
			throw new NotImplementedException();
		}

		public void NewsLetterUpdate(Writer newsletter)
		{
			throw new NotImplementedException();
		}
	}
}

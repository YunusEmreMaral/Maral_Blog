﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			_commentDal.Insert(comment);
		}

		public void CommentDelete(Comment comment)
		{
			_commentDal.Delete(comment);
		}

		public void CommentUpdate(Comment comment)
		{
			_commentDal.Update(comment);	
		}

		public List<Comment> GetAllComments(int id)
		{
			return _commentDal.GetListAll(x => x.BlogID == id);
		}

		

		public Comment GetCommentById(int id)
		{
			return _commentDal.GetById(id);
		}

        public List<Comment> GetCommentListWithBlog()
        {
            return _commentDal.GetListWithBlog();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppUI.ViewComponents.Comment
{
    public class CommentListByBlog: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}

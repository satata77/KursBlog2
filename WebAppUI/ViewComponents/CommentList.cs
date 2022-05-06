using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppUI.Models;

namespace WebAppUI.ViewComponent
{
    public class CommentList: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    username = "SADIK"
                },
                new UserComment
                {
                    ID=2,
                    username = "BORA"
                },
                new UserComment
                {
                    ID=3,
                    username = "MERVE"
                }
            };
            
            return View(commentvalues);
        }
    }
}

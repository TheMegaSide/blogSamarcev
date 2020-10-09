using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogSamarcev.Domain.DB;
using blogSamarcev.Domain.Model;
using blogSamarcev.Security.Extensions;
using blogSamarcev.ViewModels.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace blogSamarcev.Controllers
{
    /// <summary>
    /// Конструктор для работы со страницами блога
    /// </summary>
    public class blogController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public blogController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext ?? throw new ArgumentNullException(nameof(blogDbContext));
        }

        /// <summary>
        /// Метод возращающий страницу блога
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Добавление поста
        /// </summary>
        /// <returns>Переход на страницу постов пользователя</returns>
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost(NewPostViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var user = this.GetAuthorizedUser();
            var post = new BlogPost
            {
                Created = DateTime.Now,
                Data = model.Data,
                Title = model.Title,
                Owner = user.Employee


            };

            _blogDbContext.BlogPosts.Add(post);
            _blogDbContext.SaveChanges();

              
            return View();
        }
    }
}

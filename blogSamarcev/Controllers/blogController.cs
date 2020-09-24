using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogSamarcev.Controllers
{
    /// <summary>
    /// Конструктор для работы со страницами блога
    /// </summary>
    public class blogController : Controller
    {
        /// <summary>
        /// Метод возращающий страницу блога
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

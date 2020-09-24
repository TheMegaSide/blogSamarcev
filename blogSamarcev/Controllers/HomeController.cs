using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogSamarcev.Models;

namespace blogSamarcev.Controllers
{
    /// <summary>
    /// Базовый контроллер работающий с домашней страницей и страницей конфиденциальности
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// Конструктор контроллера <see cref="HomeController"/>
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Метод возвращающий домашнюю страницу
        /// </summary>
        /// <returns>Возвращает View Index </returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Метод возвращающий страницу конфиденциальности
        /// </summary>
        /// <returns>Возвращает View Privacy </returns>
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Возврат ошибки
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

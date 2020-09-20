using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogKlimov.Models;

namespace blogKlimov.Controllers

{   /// <summary>
    /// Контроллер для работы с главной страницей и политикой конфиденциальности
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Констурктор класса <see cref="HomeController"/>
        /// </summary>
        /// <param name="logger">logger</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// GET Возвращает представление страницы Home (index.cshtml)
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET Возвращает представление страницы Privacy (privacy.cshtml)
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// GET Возвращает ошибку при неудачном запросе Shared (Error.cshtml) 
        /// </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly db_123payContext _context;

        public HomeController(ILogger<HomeController> logger, db_123payContext context)
        {
            this._logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            var result = _context.TblMerchants.ToList();
            return View(result);
        }

        public IActionResult TransactionList()
        {
            var result = _context.TblPaymentTransactions.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

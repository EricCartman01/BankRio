using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankRio.Models;

namespace BankRio.Controllers
{
    public class ExchangeController : Controller
    {
        public IActionResult Index()
        {
            List<Exchange> exchanges = new List<Exchange>();

            exchanges.Add(new Exchange(new DateTime(01 / 01 / 2020)));
            return View(exchanges);
        }
    }
}

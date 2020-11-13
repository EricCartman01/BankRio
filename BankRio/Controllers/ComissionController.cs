using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankRio.Models;
using BankRio.Models.Enums;

namespace BankRio.Controllers
{
    public class ComissionController : Controller
    {

        public IActionResult Index()
        {
            var advisor1 = new Advisor(1, "Léo Monte", "LM", "leonardo.gomes@bankrio.com.br");
            var product1 = new Product(1, "CSHG Income FIC", "Descricao bla bla bla", Category.Investimento);
            var broker1 = new StockBroker(1, "XP");

            var advisor2 = new Advisor(2, "Raquel Pena", "RP", "raquel.pena@bankrio.com.br");
            var product2 = new Product(2, "XP Macro FIM", "Fundo Hedge...", Category.Seguros);
            var broker2 = new StockBroker(2, "InvestSmart");

            var advisor3 = new Advisor(3, "Carlos Rocha", "CR", "carlos.rocha@bankrio.com.br");
            var product3 = new Product(3, "XP Macro FIM", "Fundo Hedge...", Category.Seguros);
            var broker3 = new StockBroker(3, "Bank Rio");

            var advisor4 = new Advisor(4, "Leonardo Príncipe", "LP", "leonardo.principe@bankrio.com.br");
            var product4 = new Product(4, "XP Macro FIM", "Fundo Hedge...", Category.Seguros);
            var broker4 = new StockBroker(4, "InvestSmart");

            List<Comission> comissions = new List<Comission>();
            comissions.Add(new Comission(01, new DateTime(01 / 01 / 2020), broker1, advisor1, "Cert1234", Yield.Previdencia, product1, 300.00, 0.07, 0.01, 0.01));
            comissions.Add(new Comission(02, new DateTime(02 / 02 / 2020), broker2, advisor2, "Cert", Yield.Vida, product2, 500.00, 0.05, 0.01, 0.01));
            comissions.Add(new Comission(03, new DateTime(03 / 03 / 2020), broker3, advisor3, "Cert", Yield.Vida, product3, 3300.00, 0.03, 0.01, 0.01));
            comissions.Add(new Comission(04, new DateTime(04 / 04 / 2020), broker4, advisor4, "Cert", Yield.Previdencia, product4, 440.00, 0.04, 0.01, 0.01));
            
            return View(comissions);
        }
    }
}

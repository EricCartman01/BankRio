using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRio.Models;
using BankRio.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankRio.Controllers
{
    public class AdvisorController : Controller
    {
        private readonly AdvisorService _advisorService;
        public IActionResult Index()
        {
            //var advisors = _advisorService.FindAll();

            List<Advisor> lista = new List<Advisor>();
            lista.Add(new Advisor(1, "Leonardo Gomes", "LM","leonardo.gomes@bankrio.com.br"));
            lista.Add(new Advisor(2, "Raquel Pena", "RP","Raquel.Pena@bankrio.com.br"));
            lista.Add(new Advisor(3, "Carlos Rocha", "KD","carlos.rocha@bankrio.com.br"));

            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

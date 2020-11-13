  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRio.Models.Enums;

namespace BankRio.Models
{
    public class Comission
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public StockBroker StockBroker { get; set; }
        public Advisor Advisor { get; set; }
        public String Certified { get; set; }
        public Yield Yield { get; set; }

        public Product Product { get; set; }

        public Double Value { get; set; }
        public Double LiquidValue { get; set; }
        public Double PercentualAdvisor { get; set; }
        public Double ProfitAdvisor { get; set; }

        public Comission()
        {

        }

        public Comission(int id, DateTime date, StockBroker stockBroker, Advisor advisor, string certified, Yield yield, Product product, double value, double liquidValue, double percentualAdvisor, double profitAdvisor)
        {
            Id = id;
            Date = date;
            StockBroker = stockBroker;
            Advisor = advisor;
            Certified = certified;
            Yield = yield;
            Product = product;
            Value = value;
            LiquidValue = liquidValue;
            PercentualAdvisor = percentualAdvisor;
            ProfitAdvisor = profitAdvisor;
        }

        public void AddComission(Comission comission)
        {

        }


    }
}

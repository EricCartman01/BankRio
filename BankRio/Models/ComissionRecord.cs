using BankRio.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRio.Models
{
    public class ComissionRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public String Certified { get; set; }
        public Yield Yield { get; set; }
        public Advisor Advisor { get; set; }
        public Product Product { get; set; }

        public Double Value { get; set; }
        public Double LiquidValue { get; set; }
        public Double PercentualAdvisor { get; set; }
        public Double ProfitAdvisor { get; set; }




    }
}

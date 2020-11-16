using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRio.Models.Enums;

namespace BankRio.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Advisor Advisor { get; set; }
        //public string House { get; set; }
        //public Client Client { get; set; }
        public Order Order { get; set; }
        public Currency Currency { get; set; }
        public double GrossValue { get; set; }
        public double Value { get; set; }
        public double Cotation { get; set; }
        public ComissionType ComissionType { get; set; }
        public double Spread { get; set; }
        public Double Comission { get; set; }
        public double NetValue { get; set; }

        public Exchange(DateTime date)
        {
            Date = date;
        }


    }
}

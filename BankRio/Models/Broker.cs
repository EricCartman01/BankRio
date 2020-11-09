using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRio.Models
{
    public class Broker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public StockBroker StockBroker { get; set; }
        public ICollection<ComissionRecord> Sales { get; set; } = new List<ComissionRecord>();

        public Broker(int id, string name, string email, StockBroker stockBroker)
        {
            Id = id;
            Name = name;
            Email = email;
            StockBroker = stockBroker;
        }

        public void AddSales(ComissionRecord comission)
        {
            Sales.Add(comission);
        } 

        public void RemoveSales(ComissionRecord comission)
        {
            Sales.Remove(comission);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Value);
        }
    }
}

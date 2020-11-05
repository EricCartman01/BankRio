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
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Broker(int id, string name, string email, StockBroker stockBroker)
        {
            Id = id;
            Name = name;
            Email = email;
            StockBroker = stockBroker;
        }

        public void AddSales(SalesRecord sales)
        {
            Sales.Add(sales);
        } 

        public void RemoveSales(SalesRecord sales)
        {
            Sales.Remove(sales);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Value);
        }
    }
}

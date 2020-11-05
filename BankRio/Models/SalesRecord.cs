using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRio.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public Broker Broker { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
    }
}

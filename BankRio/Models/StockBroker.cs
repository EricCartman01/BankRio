 using System.Collections.Generic;

namespace BankRio.Models
{
    public class StockBroker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Broker> Brokers { get; set; } = new List<Broker>();

        public StockBroker(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddBroker(Broker broker)
        {
            Brokers.Add(broker);
        }

        public void RemoveBroker(Broker broker)
        {
            Brokers.Remove(broker);
        }
    }
}

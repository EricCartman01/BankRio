using System.Collections.Generic;
using BankRio.Models.Enums;

namespace BankRio.Models.ViewModels
{
    public class ExchangeFormViewModel
    {
        public Exchange Exchange { get; set; }
        public ICollection<Advisor> Advisors { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

using System.Collections.Generic;

namespace BankRio.Models.ViewModels
{
    public class ExchangeFormViewModel
    {
        public Exchange Exchange { get; set; }
        public ICollection<Advisor> Advisors { get; set; }
    }
}

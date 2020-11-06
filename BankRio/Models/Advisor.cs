using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRio.Models
{
    public class Advisor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string XPCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<ComissionRecord> Comissions { get; set; }


        public Advisor(string name, string initials, string xPCode, string email)
        {
            Name = name;
            Initials = initials;
            XPCode = xPCode;
            Email = email;
        }

        public void AddComissions(ComissionRecord comission)
        {
            Comissions.Add(comission);
        }

        public void RemoveComissions(ComissionRecord comission)
        {
            Comissions.Remove(comission);
        }

        public double TotalComissions(DateTime initial, DateTime final)
        {
            return (Comissions.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.ITAZ));
        }

    }
}

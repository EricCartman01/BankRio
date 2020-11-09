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
        public string Email { get; set; }
        public string Password { get; set; }
        public double NetCertification { get; set; }
        public double Net { get; set; }
        public double NetBirthday { get; set; }
        public double NetTotal { get; set; }
        public double XPC { get; set; }
        public double CMBC { get; set; }
        public double PROTC { get; set; }
        public double ITAZ { get; set; }
        public double JURC { get; set; }
        public double PAN { get; set; }
        public ICollection<ComissionRecord> Comissions { get; set; }


        public Advisor(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public Advisor(int id, string name, string initials,string email)
        {
            Id = id;
            Name = name;
            Initials = initials;
            Email = email;
        }

        public Advisor(int id, string name, string initials, string email, double netCertification, double net, double netBirthday, double netTotal, double xPC, double cMBC, double pROTC, double iTAZ, double jURC, double pAN, ICollection<ComissionRecord> comissions)
        {
            Id = id;
            Name = name;
            Initials = initials;
            Email = email;
            NetCertification = netCertification;
            Net = net;
            NetBirthday = netBirthday;
            NetTotal = netTotal;
            XPC = xPC;
            CMBC = cMBC;
            PROTC = pROTC;
            ITAZ = iTAZ;
            JURC = jURC;
            PAN = pAN;
            Comissions = comissions;
        }

        public void AddComissions(ComissionRecord comission)
        {
            Comissions.Add(comission);
        }

        public void RemoveComissions(ComissionRecord comission)
        {
            Comissions.Remove(comission);
        }

        public double Profit(DateTime initial, DateTime final)
        {
            return (Comissions.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.ProfitAdvisor));
        }

    }
}

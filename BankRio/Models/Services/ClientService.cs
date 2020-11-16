using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRio.Data;

namespace BankRio.Models.Services
{
    public class ClientService
    {
        private readonly BkRioContext _context;

        public ClientService(BkRioContext bkRioContext)
        {
            _context = bkRioContext;
        }

        public Advisor FindById(int id)
        {
            return _context.Advisor.FirstOrDefault(x => x.Id == id);
        }

        public Client FindByDocument(string document)
        {
            return _context.Client.FirstOrDefault(x => x.Document == document);
        }

    }
}

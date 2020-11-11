using BankRio.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRio.Models.Services
{
    public class AdvisorService
    {
        private readonly BkRioContext _context;

        public AdvisorService(BkRioContext bkRioContext)
        {
            _context = bkRioContext;
        }
        public void Insert(Advisor advisor) 
        {
            _context.Advisor.Add(advisor);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _context.Advisor.Find(id);
            _context.Advisor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Advisor advisor)
        {
            if (!_context.Advisor.Any(x => x.Id == advisor.Id))
            {
                throw new Exception("Assessor não Encontrado!");
            }

            try
            {
                _context.Update(advisor);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }

        public List<Advisor> FindAll()
        {
            return _context.Advisor.ToList();
        }

        public Advisor FindById(int id)
        {
            return _context.Advisor.FirstOrDefault(x => x.Id == id);
        }

        public void LoadXPS()
        {
            return;
        }

        public void LoadXP()
        {

        }


    }
}

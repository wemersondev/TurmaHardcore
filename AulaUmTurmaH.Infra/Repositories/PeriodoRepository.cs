using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Infra.Context;
using AulaUmTurmaH.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Repositories
{
    public class PeriodoRepository : IPeriodoRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public PeriodoRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Periodo periodo)
        {
            _context.Remove(periodo);
            _context.SaveChanges();
        }

        public List<Periodo> GetAll()
        {
            return _context.Periodos.ToList();
        }

        public Periodo GetById(int id)
        {
            return _context.Periodos.Find(id);
        }

        public void Insert(Periodo periodo)
        {
            _context.Periodos.Add(periodo);
            _context.SaveChanges();
        }

        public void Update(Periodo periodo)
        {
            _context.Periodos.Update(periodo);
            _context.SaveChanges();
        }
    }
}

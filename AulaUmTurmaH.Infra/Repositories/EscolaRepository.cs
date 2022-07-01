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
    public class EscolaRepository : IEscolaRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public EscolaRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Escola escola)
        {
            _context.Remove(escola);
            _context.SaveChanges();
        }

        public List<Escola> GetAll()
        {
            return _context.Escolas.ToList();
        }

        public Escola GetById(int id)
        {
            return _context.Escolas.Find(id);
        }

        public void Insert(Escola escola)
        {
            _context.Escolas.Add(escola);
            _context.SaveChanges();
        }

        public void Update(Escola escola)
        {
            _context.Escolas.Update(escola);
            _context.SaveChanges();
        }
    }
}

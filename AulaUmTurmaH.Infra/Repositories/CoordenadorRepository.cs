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
    public class CoordenadorRepository : ICoordenadorRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public CoordenadorRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Coordenador coordenador)
        {
            _context.Remove(coordenador);
            _context.SaveChanges();
        }

        public List<Coordenador> GetAll()
        {
            return _context.Coordenadores.ToList();
        }

        public Coordenador GetById(int id)
        {
            return _context.Coordenadores.Find(id);
        }

        public void Insert(Coordenador coordenador)
        {
            _context.Coordenadores.Add(coordenador);
            _context.SaveChanges();
        }

        public void Update(Coordenador coordenador)
        {
            _context.Coordenadores.Update(coordenador);
            _context.SaveChanges();
        }
    }
}

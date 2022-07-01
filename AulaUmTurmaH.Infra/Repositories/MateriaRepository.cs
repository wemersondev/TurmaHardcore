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
    public class MateriaRepository : IMateriaRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public MateriaRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Materia materia)
        {
            _context.Remove(materia);
            _context.SaveChanges();
        }

        public List<Materia> GetAll()
        {
            return _context.Materias.ToList();
        }

        public Materia GetById(int id)
        {
            return _context.Materias.Find(id);
        }

        public void Insert(Materia materia)
        {
            _context.Materias.Add(materia);
            _context.SaveChanges();
        }

        public void Update(Materia materia)
        {
            _context.Materias.Update(materia);
            _context.SaveChanges();
        }
    }
}

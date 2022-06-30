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
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public ProfessorRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Professor professor)
        {
            _context.Remove(professor);
            _context.SaveChanges();
        }

        public List<Professor> GetAll()
        {
            return _context.Professores.ToList();
        }

        public Professor GetById(int id)
        {
            return _context.Professores.Find(id);
        }

        public void Insert(Professor professor)
        {
            _context.Professores.Add(professor);
            _context.SaveChanges();
        }

        public void Update(Professor professor)
        {
            _context.Professores.Update(professor);
            _context.SaveChanges();
        }
    }
}

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

        public void Delete(Professor id)
        {
            throw new NotImplementedException();
        }

        public List<Professor> GetAll()
        {
            return _context.Professores.ToList();
        }

        public void Insert(Professor professorDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(Professor professorDTO)
        {
            throw new NotImplementedException();
        }
    }
}

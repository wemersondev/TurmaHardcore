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

        public void Delete(Materia id)
        {
            throw new NotImplementedException();
        }

        public List<Materia> GetAll()
        {
            return _context.Materias.ToList();
        }

        public void Insert(Materia MateriaDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(Materia MateriaDTO)
        {
            throw new NotImplementedException();
        }
    }
}

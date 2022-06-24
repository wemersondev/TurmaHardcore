using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface IProfessorRepository
    {
        List<Professor> GetAll();
        void Insert(Professor professor);
        void Update(Professor professor);
        void Delete(Professor id);
        Professor GetById(int id);
    }
}

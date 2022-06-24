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
        void Insert(Professor professorDTO);
        void Update(Professor professorDTO);
        void Delete(Professor id);
    }
}

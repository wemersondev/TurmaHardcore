using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface IProfessorApplication
    {
        List<ProfessorDTO> GetAll();
        void Insert(ProfessorDTO professorDTO);
        void Update(ProfessorDTO professorDTO);
        void Delete(int id);
    }
}

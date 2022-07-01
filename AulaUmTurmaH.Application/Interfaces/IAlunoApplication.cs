using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface IAlunoApplication
    {
        List<AlunoDTO> GetAll();
        void Insert(AlunoDTO alunoDTO);
        void Update(AlunoDTO alunoDTO);
        void Delete(int id);
    }
}

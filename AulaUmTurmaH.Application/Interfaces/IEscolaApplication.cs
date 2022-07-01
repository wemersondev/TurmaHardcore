using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface IEscolaApplication
    {
        List<EscolaDTO> GetAll();
        void Insert(EscolaDTO escolaDTO);
        void Update(EscolaDTO escolaDTO);
        void Delete(int id);
    }
}

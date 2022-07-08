using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface IPeriodoApplication
    {
        List<PeriodoDTO> GetAll();
        void Insert(PeriodoDTO PeriodoDTO);
        void Update(PeriodoDTO PeriodoDTO);
        void Delete(int id);
    }
}

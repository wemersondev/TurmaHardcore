using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface IPeriodoRepository
    {
        List<Periodo> GetAll();
        void Insert(Periodo PeriodoDTO);
        void Update(Periodo PeriodoDTO);
        void Delete(Periodo id);
        Periodo GetById(int id);
    }
}

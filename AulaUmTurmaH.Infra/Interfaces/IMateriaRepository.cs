using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface IMateriaRepository
    {
        List<Materia> GetAll();
        void Insert(Materia materiaDTO);
        void Update(Materia materiaDTO);
        void Delete(Materia id);
        Materia GetById(int id);
    }
}

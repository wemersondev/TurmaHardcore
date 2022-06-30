using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface IMateriaApplication
    {
        List<MateriaDTO> GetAll();
        //void Insert(MateriaDTO materiaDTO);
        //void Update(MateriaDTO materiaDTO);
        //void Delete(int id);
    }
}

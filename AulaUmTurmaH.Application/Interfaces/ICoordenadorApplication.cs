using AulaUmTurmaH.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.Interfaces
{
    public interface ICoordenadorApplication
    {
        List<CoordenadorDTO> GetAll();
        void Insert(CoordenadorDTO coordenadorDTO);
        void Update(CoordenadorDTO coordenadorDTO);
        void Delete(int id);
    }
}

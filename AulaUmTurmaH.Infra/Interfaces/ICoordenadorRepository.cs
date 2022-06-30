using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface ICoordenadorRepository
    {
        List<Coordenador> GetAll();
        void Insert(Coordenador coordenador);
        void Update(Coordenador coordenador);
        void Delete(Coordenador coordenador);
        Coordenador GetById(int id);
    }
}

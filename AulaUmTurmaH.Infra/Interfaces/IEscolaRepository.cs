using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface IEscolaRepository
    {
        List<Escola> GetAll();
        void Insert(Escola escola);
        void Update(Escola escola);
        void Delete(Escola id);
        Escola GetById(int id);
    }
}

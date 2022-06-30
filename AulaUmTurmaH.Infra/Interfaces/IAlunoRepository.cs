using AulaUmTumaH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();
        void Insert(Aluno aluno);
        void Update(Aluno aluno);
        void Delete(Aluno aluno);
        Aluno GetById(int id);
    }
}

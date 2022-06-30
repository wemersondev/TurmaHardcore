using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Infra.Context;
using AulaUmTurmaH.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AulaUmTurmaHContext _context;
        public AlunoRepository(AulaUmTurmaHContext context)
        {
            _context = context;
        }

        public void Delete(Aluno aluno)
        {
            _context.Remove(aluno);
            _context.SaveChanges();
        }

        public List<Aluno> GetAll()
        {
            return _context.Alunos.ToList();
        }

        public Aluno GetById(int id)
        {
            return _context.Alunos.Find(id);
        }

        public void Insert(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }
    }
}

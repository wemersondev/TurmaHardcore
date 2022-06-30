using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Interfaces;

namespace AulaUmTurmaH.Application.Applications
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoApplication(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public List<AlunoDTO> GetAll()
        {
            List<Aluno> alunos = _alunoRepository.GetAll();
            return alunos.Select(aluno => new AlunoDTO 
            {
                CPF = aluno.CPF,
                CriadoEm  = aluno.CriadoEm,
                DataNascimento = aluno.DataNascimento,
                Email = aluno.Email,
                Excluido = aluno.Excluido,
                Id = aluno.Id,
                Nome = aluno.Nome,
                IdEscola = aluno.IdEscola
            }).ToList();
        }

        public void Insert(AlunoDTO alunoDTO)
        {
            var aluno = new Aluno 
            {
                CPF = alunoDTO.CPF,
                DataNascimento = alunoDTO.DataNascimento,
                Email = alunoDTO.Email,
                Nome = alunoDTO.Nome,
                IdEscola= alunoDTO.IdEscola
            };
            aluno.InserirDadosBase();
            _alunoRepository.Insert(aluno);
        }

        public void Update(AlunoDTO alunoDTO)
        {
            var aluno = _alunoRepository.GetById(alunoDTO.Id);
            aluno.CPF = alunoDTO.CPF;
            aluno.DataNascimento = alunoDTO.DataNascimento;
            aluno.Email = alunoDTO.Email;
            aluno.Nome = alunoDTO.Nome;
            aluno.IdEscola = alunoDTO.IdEscola;
            _alunoRepository.Update(aluno);
        }

        public void Delete(int id)
        {
            Aluno aluno = _alunoRepository.GetById(id);
            _alunoRepository.Delete(aluno);
        }
    }
}

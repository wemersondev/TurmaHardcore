using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Interfaces;

namespace AulaUmTurmaH.Application.Applications
{
    public class ProfessorApplication : IProfessorApplication
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorApplication(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public List<ProfessorDTO> GetAll()
        {
            List<Professor> professores = _professorRepository.GetAll();
            return professores.Select(professor => new ProfessorDTO 
            {
                CPF = professor.CPF,
                CriadoEm  = professor.CriadoEm,
                DataNascimento = professor.DataNascimento,
                Email = professor.Email,
                Excluido = professor.Excluido,
                Id = professor.Id,
                Nome = professor.Nome,
                RGP = professor.RGP
            }).ToList();
        }

        public void Insert(ProfessorDTO professorDTO)
        {
            var professor = new Professor 
            {
                CPF = professorDTO.CPF,
                DataNascimento = professorDTO.DataNascimento,
                Email = professorDTO.Email,
                Nome = professorDTO.Nome,
                RGP = professorDTO.RGP
            };
            professor.InserirDadosBase();
            _professorRepository.Insert(professor);
        }

        public void Update(ProfessorDTO professorDTO)
        {
            var professor = _professorRepository.GetById(professorDTO.Id);
            professor.RGP = professorDTO.RGP;
            professor.CPF = professorDTO.CPF;
            professor.DataNascimento = professorDTO.DataNascimento;
            professor.Email = professorDTO.Email;
            professor.Nome = professorDTO.Nome;
            _professorRepository.Update(professor);
        }

        public void Delete(int id)
        {
            Professor professor = _professorRepository.GetById(id);
            _professorRepository.Delete(professor);
        }
    }
}

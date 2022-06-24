using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Nome = professor.Nome
            }).ToList();
        }
    }
}

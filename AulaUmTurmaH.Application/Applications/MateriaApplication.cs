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
    public class MateriaApplication : IMateriaApplication
    {
        private readonly IMateriaRepository _materiaRepository;
        public MateriaApplication(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        public List<MateriaDTO> GetAll()
        {
            List<Materia> materias = _materiaRepository.GetAll();
            return materias.Select(materias => new MateriaDTO 
            {                
                Nome = materias.Nome
            }).ToList();
        }
    }
}

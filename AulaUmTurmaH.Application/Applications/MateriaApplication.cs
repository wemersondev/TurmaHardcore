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
                Id = materias.Id,
                Nome = materias.Nome
            }).ToList();
        }

        public void Insert(MateriaDTO materiaDTO)
        {
            var materia = new Materia
            {                
                Nome = materiaDTO.Nome,
            };
            materia.InserirDadosBase();
            _materiaRepository.Insert(materia);
        }

        public void Update(MateriaDTO materiaDTO)
        {
            var materia = _materiaRepository.GetById(materiaDTO.Id);            
            materia.Nome = materiaDTO.Nome;
            _materiaRepository.Update(materia);
        }

        public void Delete(int id)
        {
            Materia Materia = _materiaRepository.GetById(id);
            _materiaRepository.Delete(Materia);
        }
    }
}

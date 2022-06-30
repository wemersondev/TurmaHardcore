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
    public class PeriodoApplication : IPeriodoApplication
    {
        private readonly IPeriodoRepository _periodoRepository;
        public PeriodoApplication(IPeriodoRepository periodoRepository)
        {
            _periodoRepository = periodoRepository;
        }

        public List<PeriodoDTO> GetAll()
        {
            List<Periodo> periodos = _periodoRepository.GetAll();
            return periodos.Select(periodo => new PeriodoDTO 
            {
                DataInicio = periodo.DataInicio,
                DataFim = periodo.DataFim
            }).ToList();
        }

        public void Insert(PeriodoDTO periodoDTO)
        {
            var periodo = new Periodo
            {
                DataInicio = periodoDTO.DataInicio,
                DataFim = periodoDTO.DataFim,
            };
            periodo.InserirDadosBase();
            _periodoRepository.Insert(periodo);
        }

        public void Update(PeriodoDTO periodoDTO)
        {
            var periodo = _periodoRepository.GetById(periodoDTO.Id);
            periodo.DataInicio = periodoDTO.DataInicio;
            periodo.DataFim = periodoDTO.DataFim;
            
            _periodoRepository.Update(periodo);
        }

        public void Delete(int id)
        {
            Periodo periodo = _periodoRepository.GetById(id);
            _periodoRepository.Delete(periodo);
        }
    }
}

using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Interfaces;

namespace AulaUmTurmaH.Application.Applications
{
    public class CoordenadorApplication : ICoordenadorApplication
    {
        private readonly ICoordenadorRepository _coordenadorRepository;
        public CoordenadorApplication(ICoordenadorRepository coordenadorRepository)
        {
            _coordenadorRepository = coordenadorRepository;
        }

        public List<CoordenadorDTO> GetAll()
        {
            List<Coordenador> coordenador = _coordenadorRepository.GetAll();
            return coordenador.Select(coordenador => new CoordenadorDTO
            {
                CPF = coordenador.CPF,
                CriadoEm  = coordenador.CriadoEm,
                DataNascimento = coordenador.DataNascimento,
                Email = coordenador.Email,
                Excluido = coordenador.Excluido,
                Id = coordenador.Id,
                Nome = coordenador.Nome
            }).ToList();
        }

        public void Insert(CoordenadorDTO coordenadorDTO)
        {
            var coordenador = new Coordenador
            {
                CPF = coordenadorDTO.CPF,
                DataNascimento = coordenadorDTO.DataNascimento,
                Email = coordenadorDTO.Email,
                Nome = coordenadorDTO.Nome
            };
            coordenador.InserirDadosBase();
            _coordenadorRepository.Insert(coordenador);
        }

        public void Update(CoordenadorDTO coordenadorDTO)
        {
            var coordenador = _coordenadorRepository.GetById(coordenadorDTO.Id);
            coordenador.CPF = coordenadorDTO.CPF;
            coordenador.DataNascimento = coordenadorDTO.DataNascimento;
            coordenador.Email = coordenadorDTO.Email;
            coordenador.Nome = coordenadorDTO.Nome;
            _coordenadorRepository.Update(coordenador);
        }

        public void Delete(int id)
        {
            var coordenador = _coordenadorRepository.GetById(id);
            _coordenadorRepository.Delete(coordenador);
        }
    }
}

using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Interfaces;

namespace AulaUmTurmaH.Application.Applications
{
    public class EscolaApplication : IEscolaApplication
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaApplication(IEscolaRepository escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }

        public List<EscolaDTO> GetAll()
        {
            List<Escola> escolas = _escolaRepository.GetAll();
            return escolas.Select(escola => new EscolaDTO 
            {

                Nome = escola.Nome,
                Email = escola.Email,
                CNPJ = escola.CNPJ,
                Bairro = escola.Bairro,
                Cidade = escola.Cidade,
                CriadoEm = escola.CriadoEm,
                Estado = escola.Estado,
                Excluido = escola.Excluido,
                HorarioFuncionamento = escola.HorarioFuncionamento,
                Id = escola.Id,
                Numero = escola.Numero ,
                Rua = escola.Rua,

            }).ToList();
        }

        public void Insert(EscolaDTO escolaDTO)
        {
            var escola = new Escola 
            {
                Nome = escolaDTO.Nome,
                Email = escolaDTO.Email,
                CNPJ = escolaDTO.CNPJ,
                Bairro = escolaDTO.Bairro,
                Cidade = escolaDTO.Cidade,
                Estado = escolaDTO.Estado,
                HorarioFuncionamento = escolaDTO.HorarioFuncionamento,
                Numero = escolaDTO.Numero,
                Rua = escolaDTO.Rua,
            };
            escola.InserirDadosBase();
            _escolaRepository.Insert(escola);
        }

        public void Update(EscolaDTO escolaDTO)
        {
            var escola = _escolaRepository.GetById(escolaDTO.Id);
            escola.Nome = escolaDTO.Nome;
            escola.Email = escolaDTO.Email;
            escola.CNPJ = escolaDTO.CNPJ;
            escola.Bairro = escolaDTO.Bairro;
            escola.Cidade = escolaDTO.Cidade;
            escola.Estado = escolaDTO.Estado;
            escola.HorarioFuncionamento = escolaDTO.HorarioFuncionamento;
            escola.Numero = escolaDTO.Numero;
            escola.Rua = escolaDTO.Rua;
            _escolaRepository.Update(escola);
        }

        public void Delete(int id)
        {
            Escola escola = _escolaRepository.GetById(id);
            _escolaRepository.Delete(escola);
        }
    }
}

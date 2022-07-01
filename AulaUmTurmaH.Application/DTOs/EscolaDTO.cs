using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.DTOs
{
    public class EscolaDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string CNPJ { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime HorarioFuncionamento { get; set; }

        public bool Excluido { get; set; }
    }
}

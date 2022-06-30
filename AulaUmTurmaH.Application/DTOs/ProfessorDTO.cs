using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Application.DTOs
{
    public class ProfessorDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string RGP { get; set; }

        public string CPF { get; set; }

        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public bool Excluido { get; set; }
    }
}

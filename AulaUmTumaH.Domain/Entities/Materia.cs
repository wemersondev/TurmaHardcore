using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTumaH.Domain.Entities
{
    public class Materia : EntityBase
    {
        public string Nome { get; set; }

        public ICollection<Aluno> Alunos { get; set; }

        public int PeriodoId { get; set; }

        public Periodo Periodo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTumaH.Domain.Entities
{
    public class Periodo : EntityBase
    {
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public ICollection<Materia> Materias { get; set; }
    }
}

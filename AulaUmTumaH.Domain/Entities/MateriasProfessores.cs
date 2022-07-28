using AulaUmTumaH.Domain.Enum;

namespace AulaUmTumaH.Domain.Entities
{
    public class MateriasProfessores : EntityBase
    {
        public int ProfessorId { get; set; }
        public Professor Professores { get; set; }
        public int MateriaId { get; set; }
        public Materia Materias { get; set; }
        public int Ano { get; set; }
        public PeriodoEnum Periodo { get; set; }
        public ICollection<Nota> Notas { get; set; }
    }
}

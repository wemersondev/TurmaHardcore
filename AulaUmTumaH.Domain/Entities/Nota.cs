using AulaUmTumaH.Domain.Enum;

namespace AulaUmTumaH.Domain.Entities
{
    public class Nota: EntityBase
    
    {                     
        public AvaliacoesEnum Avaliacoes { get; set; }        
        public int MatriculaId { get; set; }
        public Matricula Matriculas { get; set; }
        public MateriasProfessores MateriasProfessores { get; set; }        
    }
}

namespace AulaUmTumaH.Domain.Entities
{
    public class Matricula : EntityBase
    {
        public int AlunoId { get; set; }
        public Aluno Alunos { get; set; }
        public int MateriaId { get; set; }
        public Materia Materias { get; set; }
        public int Ano { get; set; }        
    }
}

namespace AulaUmTumaH.Domain.Entities
{
    public class AlunoMateria 
    {
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public int MateriaId { get; set; }

        public Materia Materia { get; set; }
    }
}
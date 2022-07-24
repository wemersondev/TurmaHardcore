using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AulaUmTurmaH.Infra.Context
{
    public class AulaUmTurmaHContext : DbContext
    {
        public AulaUmTurmaHContext(DbContextOptions<AulaUmTurmaHContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Coordenador> Coordenadores { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EscolaConfiguration).Assembly);            
        }
    }
}

using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EscolaConfiguration).Assembly);            

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}

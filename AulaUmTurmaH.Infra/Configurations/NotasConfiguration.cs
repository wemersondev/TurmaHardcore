using AulaUmTumaH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaUmTurmaH.Infra.Configurations
{
    public class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.HasOne(c => c.Matricula)
                .WithMany(c => c.Notas)
                .HasForeignKey(c => c.MatriculaId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(c => c.MateriasProfessores)
                .WithMany(c => c.Notas)
                .HasForeignKey(c => c.MateriasProfessoresId)
                .OnDelete(DeleteBehavior.Restrict);



        }
    }
}

using AulaUmTumaH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaUmTurmaH.Infra.Configurations
{
    public class EscolaConfiguration : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.Property(prop => prop.Nome)
                .HasMaxLength(200);
            
        }
    }
}

using AulaUmTumaH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmTurmaH.Infra.Configurations
{
    public class PeriodoConfiguration : IEntityTypeConfiguration<Periodo>
    {
        public void Configure(EntityTypeBuilder<Periodo> builder)
        {
            builder.Property(prop => prop.DataInicio)
                .IsRequired();

            builder.Property(prop => prop.DataFim)
                .IsRequired();            
        }
    }
}

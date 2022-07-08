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
    public class CoordenadorConfiguration : IEntityTypeConfiguration<Coordenador>
    {
        public void Configure(EntityTypeBuilder<Coordenador> builder)
        {
           builder.HasOne(prop=>prop.Escola)
                .WithMany(prop=>prop.Coordenadores)
                .HasForeignKey(prop=>prop.EscolaId);

        }
    }
}

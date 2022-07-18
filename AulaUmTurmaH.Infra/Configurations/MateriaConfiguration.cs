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
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder
                .HasMany(p => p.Alunos)
                .WithMany(p => p.Materias)
                .UsingEntity(j => j.ToTable("AlunoMateria"));


            builder
                .HasOne(prop => prop.Periodo)
                .WithMany(prop => prop.Materias)
                .HasForeignKey(prop => prop.Id);

        }
    }
}

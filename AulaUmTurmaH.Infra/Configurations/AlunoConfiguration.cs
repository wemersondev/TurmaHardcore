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
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
                builder
                 .HasMany(p => p.Materias)
                 .WithMany(p => p.Alunos)
                 .UsingEntity(j => j.ToTable("AlunoMateria"));

        }
    }
}

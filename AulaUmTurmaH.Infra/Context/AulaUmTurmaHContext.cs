using AulaUmTumaH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

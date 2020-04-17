using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data
{
    public partial class escolaContext : DbContext
    {
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Matricula> Matriculas { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public escolaContext()
        {
        }

        public escolaContext(DbContextOptions<escolaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite("Data Source=escola.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

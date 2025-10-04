using Entity.Model.Colegio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context.Main
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Estudiantes> Estudiantes {  get; set; }
        public DbSet<Colegio> Colegios { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Asignaturas>  Asignaturas { get; set; }
        public DbSet<CursoAsignatura> CursoAsignatura { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<Periodos> Periodos { get; set; }
        public DbSet<Salones> Salones { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
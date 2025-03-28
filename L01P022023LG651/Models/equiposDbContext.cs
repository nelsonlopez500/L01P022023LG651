using L01P022023LG651.Models;
using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options): base(options)
        {
        }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Facultad> facultades { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<Alumno> alumnos { get; set; }
    }
}

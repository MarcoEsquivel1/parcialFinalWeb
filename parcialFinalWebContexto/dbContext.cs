using Microsoft.EntityFrameworkCore;
using parcialFinalWebEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialFinalWebContexto
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }


        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<certificadoscursos> certificadoscursos { get; set; }
        public DbSet<habilidades> habilidades { get; set; }
        public DbSet<experiencias> experiencias { get; set; }
        public DbSet<portafolios> portafolios { get; set; }

        public DbSet<gradosacademicos> gradosAcademicos { get; set; }
    }
}

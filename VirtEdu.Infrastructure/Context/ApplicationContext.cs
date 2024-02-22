using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RespuestaForo> RespuestasForos { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Foro> Foros { get; set; }
        public DbSet<ContenidoEducativo> ContenidosEducativos { get; set; }
        

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<Asignacion> Asignaciones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
using DgNotification.DataAccess.Enums;
using DgNotification.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess
{
    public class clsDGNotiDBContext : DbContext
    {
        public clsDGNotiDBContext(DbContextOptions<clsDGNotiDBContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCompra> Compras { get; set; }
        public DbSet<clsMedicamento> Medicamentos { get; set; }
        public DbSet<clsMedicamentoFrecuencia> MedicamentoFrecuencias { get; set; }
        public DbSet<clsNotificacion> Notificaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<clsCliente>().HasIndex(c => c.Cedula).IsUnique(); modelBuilder.Entity<clsMedicamento>()
            .Property(m => m.Precio)
            .HasColumnType("DECIMAL(18, 2)");

            modelBuilder.Entity<clsCompra>()
                .Property(c => c.PrecioUnitario)
                .HasColumnType("DECIMAL(18, 2)");

            modelBuilder.Entity<clsNotificacion>()
                .Property(n => n.Estado)
                .HasDefaultValue(NotificacionEstado.Pendiente)
                .HasSentinel(NotificacionEstado.Pendiente);
        }
    }
}


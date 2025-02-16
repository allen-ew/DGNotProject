using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Models
{

    public class clsCliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string NumeroContacto { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; } = true;

        //Relaciones
        public ICollection<clsCompra> Compras { get; set; }
        public ICollection<clsNotificacion> Notificaciones { get; set; }
        public ICollection<clsMedicamentoFrecuencia> MedicamentoFrecuencias { get; set; }

    }
}


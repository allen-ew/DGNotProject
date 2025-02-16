using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Models
{
    public class clsMedicamento
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }
        public bool Activo { get; set; } = true;

        //Relaciones

        public ICollection<clsCompra> Compras { get; set; }
        public ICollection<clsMedicamentoFrecuencia> MedicamentosFrecuencia { get; set; }
        public ICollection<clsNotificacion> Notificaciones { get; set; }

    }
}

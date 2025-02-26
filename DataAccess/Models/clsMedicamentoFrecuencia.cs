﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Models
{
    public class clsMedicamentoFrecuencia
    {
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public clsCliente Cliente { get; set; }

        [ForeignKey("Medicamento")]
        public int MedicamentoId { get; set; }
        public clsMedicamento Medicamento { get; set; }

        [Required]
        public int FrecuenciaDiaria { get; set; }


    }
}

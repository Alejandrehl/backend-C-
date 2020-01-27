﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSwaggers.Models
{
    [Table("correo", Schema = "public")]
    public class CorreoJoinCliente
    {
        [Key]
        public int id_correo { get; set; }
        public string correo { get; set; }
        public DateTime fecha_ingreso { get; set; }

        [ForeignKey("id_cliente")]
        public int id_cliente { get; set; }

        public Cliente cliente { get; set; }
    }
}

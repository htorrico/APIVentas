using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasAPI.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
    }
}
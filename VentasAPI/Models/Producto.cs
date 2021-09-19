using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasAPI.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
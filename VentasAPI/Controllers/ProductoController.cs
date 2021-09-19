using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace VentasAPI.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: Producto
        public List<Producto> Get()
        {

            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto { Id = 1, Nombre = "Manzana", Precio = 10 });
            productos.Add(new Producto { Id = 2, Nombre = "Naranja", Precio = 20 });
            productos.Add(new Producto { Id = 3, Nombre = "Fresa", Precio = 30 });
            return productos;
        }

    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

}
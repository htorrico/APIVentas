using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VentasAPI.Models;

namespace VentasAPI
{
    public class VentasContexto : DbContext
    {

        public VentasContexto(): base("name= MyContextDB")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using VentasAPI.Models;

namespace VentasAPI.Controllers
{
    public class ClienteController : ApiController
    {
        VentasContexto contexto = new VentasContexto();
        // GET: Cliente
        public List<Cliente> Get()
        {
            return contexto.Clientes.ToList();
        }
    }
}
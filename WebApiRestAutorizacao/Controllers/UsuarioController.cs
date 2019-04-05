using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRestAutorizacao.Models;

namespace WebApiRestAutorizacao.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public List<Usuario> GetAll()
        {
            return new Usuario().list();
        }

        // GET: api/Usuario/5
        public Usuario Get(int Id)
        {
            return new Usuario().Get(Id);
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {

        }
    }
}

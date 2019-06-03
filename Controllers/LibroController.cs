using Negocio;
using Persistencia5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC5.Controllers
{
    public class LibroController : ApiController
    {
        private LibroRepository repositorio;


        public LibroController()
        {

            this.repositorio = new LibroRepository();
        }

        // GET api/<controller>
        public IEnumerable<Libro> Get()
        {
            return repositorio.BuscarTodos();
        }

        // GET api/<controller>/5
        public Libro Get(string id)
        {
            return repositorio.BuscarUno(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Libro value)
        {
            repositorio.Insertar(value);
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]Libro value)
        {
            repositorio.Borrar(new Libro(id));
            repositorio.Insertar(value);
        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {

            repositorio.Borrar(new Libro(id));
        }
    }
}
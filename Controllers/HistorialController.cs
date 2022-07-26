using System;
using back_salidaActivos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class HistorialController : ApiController
    {
        // GET: api/Historial
        public IEnumerable<historial> Get()
        {
            GestorHistorial gHistorial = new GestorHistorial();
            return gHistorial.GetHistorials();
        }

        // GET: api/Historial/5
        public IEnumerable<historial> Get(int id)
        {
            GestorHistorial gHistorial = new GestorHistorial();
            return gHistorial.GetHistorialsById2(id);
        }

        // POST: api/Historial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Historial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Historial/5
        public void Delete(int id)
        {
        }
    }
}

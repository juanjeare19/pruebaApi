using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace pruebaApi.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult agregar(Models.Request.PersonaRequest model)
        {
            using (Models.pruebaApiEntities db = new Models.pruebaApiEntities())
            {
                var oPersona = new Models.persona();
                oPersona.nombre = model.Nombre;
                oPersona.edad = model.Edad;
                db.personas.Add(oPersona);
                db.SaveChanges();
            }
            return Ok("exito");
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using backend_net.app.models;

namespace backend_net.app.controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        private static List<Contacto> contactos = new List<Contacto>();

        [HttpGet]
        public ActionResult<IEnumerable<Contacto>> Get()
        {
            return Ok(contactos);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Contacto contacto)
        {
            contacto.IdContacto = contactos.Count > 0 ? contactos.Max(c => c.IdContacto) + 1 : 1;
            contactos.Add(contacto);
            return CreatedAtAction(nameof(Get), new { id = contacto.IdContacto }, contacto);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var contacto = contactos.FirstOrDefault(c => c.IdContacto == id);
            if (contacto == null)
            {
                return NotFound();
            }

            contactos.Remove(contacto);
            return NoContent();
        }
    }
}
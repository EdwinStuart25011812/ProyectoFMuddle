using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtEdu.Domain.Entities;

namespace ProyectoFinalMuddle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignacionController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Asignacion>>> GetAllAsignaciones()
        {
            var asignaciones = new List<Asignacion> {
                new Asignacion
                {
                    ID_asignacion = 1,
                    ID_usuario = 1,
                    titulo = "Tarea 1",
                    descripcion = "Descripción de la tarea 1",
                    fecha_inicio = DateTime.Now,
                    fecha_limite = DateTime.Now.AddDays(7),
                    archivo_adjunto = "adjunto1.pdf"
                }
                
            };

            return Ok(asignaciones);
        }
    }
}

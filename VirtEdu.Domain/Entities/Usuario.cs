using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int ID_usuario { get; set; }
        public string nombre { get; set; } 
        public string correo_electronico { get; set; } 
        public string contraseña { get; set; }
        public string tipo_usuario { get; set; } 


        // Relaciones con otras entidades
        /*
        public ICollection<Asignacion> Asignaciones { get; set; }
        public ICollection<ContenidoEducativo> ContenidosEducativos { get; set; }
        public ICollection<Mensaje> MensajesEnviados { get; set; }
        public ICollection<Mensaje> MensajesRecibidos { get; set; }
        public ICollection<Foro> ForosCreados { get; set; }
        public ICollection<RespuestaForo> RespuestasForos { get; set; }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class Mensaje
    {
        public int ID_mensaje { get; set; }
        public int ID_usuario_emisor { get; set; }
        public int ID_usuario_receptor { get; set; }
        public string contenido { get; set; }
        public DateTime fecha_envio { get; set; }
        public bool estado_leido { get; set; }

        // Relaciones con Usuario
        public Usuario Emisor { get; set; } 
        public Usuario Receptor { get; set; }
    }
}

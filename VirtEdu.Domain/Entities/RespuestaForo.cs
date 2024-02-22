using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class RespuestaForo
    {
        public int ID_respuesta { get; set; }
        public int ID_usuario_respuesta { get; set; }
        public int ID_tema_foro { get; set; }
        public string contenido { get; set; }
        public DateTime fecha_envio { get; set; }

        // Relaciones con Usuario y Foro
        public Usuario Usuario { get; set; }
        public Foro Foro { get; set; }
    }
}

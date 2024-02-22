using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class Foro
    {
        public int ID_tema { get; set; }
        public int ID_usuario_creador { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_creacion { get; set; }

        // Relación con Usuario
        public Usuario Usuario { get; set; }
    }
}

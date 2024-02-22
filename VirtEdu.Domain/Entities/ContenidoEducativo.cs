using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class ContenidoEducativo
    {
        public int ID_contenido { get; set; }
        public int ID_usuario_profesor { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string tipo_contenido { get; set; }
        public string archivo_adjunto { get; set; }

        // Relación con Usuario
        public Usuario Usuario { get; set; }
    }
}

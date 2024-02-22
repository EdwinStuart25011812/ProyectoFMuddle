using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtEdu.Domain.Entities
{
    public class Asignacion
    {
        public int ID_asignacion { get; set; }
       
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_limite { get; set; }
        public string archivo_adjunto { get; set; }

        // Relación con Usuario
        [ForeignKey("Usuario")]
        public int ID_usuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}

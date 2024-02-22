using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Domain.Interfaces
{
    public interface IContenidoEducativoRepository
    {
        IEnumerable<ContenidoEducativo> GetAll();
        ContenidoEducativo GetById(int id);
        void Add(ContenidoEducativo contenidoEducativo);
        void Update(ContenidoEducativo contenidoEducativo);
        void Delete(int id);
    }
}

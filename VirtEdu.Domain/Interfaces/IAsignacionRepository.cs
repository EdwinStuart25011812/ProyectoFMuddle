using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Domain.Interfaces
{
    public interface IAsignacionRepository
    {
        IEnumerable<Asignacion> GetAll();
        Asignacion GetById(int id);
        void Add(Asignacion asignacion);
        void Update(Asignacion asignacion);
        void Delete(int id);
    }
}

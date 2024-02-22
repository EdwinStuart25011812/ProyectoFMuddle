using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Domain.Interfaces
{
    public interface IMensajeRepository
    {
        IEnumerable<Mensaje> GetAll();
        Mensaje GetById(int id);
        void Add(Mensaje mensaje);
        void Update(Mensaje mensaje);
        void Delete(int id);
    }
}

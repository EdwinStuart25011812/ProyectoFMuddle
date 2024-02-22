using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Domain.Interfaces
{
    public interface IForoRepository
    {
        IEnumerable<Foro> GetAll();
        Foro GetById(int id);
        void Add(Foro foro);
        void Update(Foro foro);
        void Delete(int id);
    }
}

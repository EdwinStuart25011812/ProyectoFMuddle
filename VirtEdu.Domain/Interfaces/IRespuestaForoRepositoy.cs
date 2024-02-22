using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtEdu.Domain.Entities;

namespace VirtEdu.Domain.Interfaces
{
    public interface IRespuestaForoRepositoy
    {
        IEnumerable<RespuestaForo> GetAll();
        RespuestaForo GetById(int id);
        void Add(RespuestaForo respuestaForo);
        void Update(RespuestaForo respuestaForo);
        void Delete(int id);
    }
}

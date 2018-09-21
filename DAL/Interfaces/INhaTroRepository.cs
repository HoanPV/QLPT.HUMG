using DAL.EntityFramework;
using QLPT.HUMG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Interfaces
{
    public interface INhaTroRepository
    {
        IEnumerable<NhaTro> GetAll();
        long Count();
        void Create(NhaTro obj);
        void Delete(object Id);
        NhaTro GetById(object Id);
        void Update(NhaTro obj);
    }
}

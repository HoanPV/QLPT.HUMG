using DAL.EntityFramework;
using QLPT.HUMG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Interfaces
{
    public interface IPhongRepository
    {
        IEnumerable<Phong> GetAll();
        long Count();
        void Create(Phong obj);
        void Delete(object Id);
        Phong GetById(object Id);
        void Update(Phong obj);

    }
}

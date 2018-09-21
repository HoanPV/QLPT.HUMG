using DAL.EntityFramework;
using QLPT.HUMG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Interfaces
{
    public interface IDichVuRepository
    {
        IEnumerable<DichVu> GetAll();
        long Count();
        void Create(DichVu obj);
        void Delete(object Id);
        DichVu GetById(object Id);
        void Update(DichVu obj);

    }
}

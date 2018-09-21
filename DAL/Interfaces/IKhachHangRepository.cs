using DAL.EntityFramework;
using QLPT.HUMG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Interfaces
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetAll();
        long Count();
        void Create(KhachHang obj);
        void Delete(object Id);
        KhachHang GetById(object Id);
        void Update(KhachHang obj);
    }
}

using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.BLL.IBusinessService
{
    public interface IKhachHangService
    {
        IList<KhachHang> KhachHang_GetAll();
        bool KhachHang_Insert(KhachHang khachHang);
        bool KhachHang_Update(KhachHang khachHang);
        bool KhachHang_Delete(Guid Id);
        KhachHang KhachHang_GetById(Guid Id);

    }
}

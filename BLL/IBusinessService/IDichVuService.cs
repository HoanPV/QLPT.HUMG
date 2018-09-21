using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.BLL.IBusinessService
{
    public interface IDichVuService
    {
        IList<DichVu> DichVu_GetAll();
        bool DichVu_Insert(DichVu dichVu);
        bool DichVu_Update(DichVu dichVu);
        bool DichVu_Delete(Guid Id);
        DichVu DichVu_GetById(Guid Id);
    }
}

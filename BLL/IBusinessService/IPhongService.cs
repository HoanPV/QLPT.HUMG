using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.BLL.IBusinessService
{
    public interface IPhongService
    {
        IList<Phong> Phong_GetAll();
        bool Phong_Insert(Phong phong);
        bool Phong_Update(Phong phong);
        bool Phong_Delete(Guid Id);
        Phong Phong_GetById(Guid Id);
    }
}

using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.BLL.IBusinessService
{
    public interface INhaTroService
    {
        IList<NhaTro> NhaTro_GetAll();
        bool NhaTro_Insert(NhaTro phong);
        bool NhaTro_Update(NhaTro phong);
        bool NhaTro_Delete(Guid Id);
        NhaTro NhaTro_GetById(Guid Id);
    }
}

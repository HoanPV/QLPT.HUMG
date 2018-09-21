using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Model
{
    public class ThuePhong : SharedProvider
    {
        public Guid Id { get; set; }
        public String Ma { get; set; }
        public Guid? Id_KhachHang { get; set; }
        public Guid? Id_Phong { get; set; }
        public DateTime Ngay_Den { get; set; }
        public DateTime Ngay_Di { get; set; }
        public String Ten_Nhan_Vien { get; set; }

    }
}

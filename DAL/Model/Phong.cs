using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Model
{
    public class Phong:SharedProvider
    {
        public Guid Id { get; set; }
        public String Ma_Phong { get; set; }
        public String Ten_Phong { get; set; }
        public String Loai_Phong { get; set; }
        public Int32 Gia_Phong { get; set; }
        public String Tinh_Trang { get; set; }


    }
}

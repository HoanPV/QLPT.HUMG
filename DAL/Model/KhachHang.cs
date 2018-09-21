using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Model
{
    public class KhachHang:SharedProvider
    {
        
        public Guid Id { get; set; }
        public String Ma_Khach_Hang { get; set; }
        public String Ten_Khach_Hang { get; set; }
        public String CMT { get; set; }
        public String Ho_Ten { get; set; }
        public String Dia_Chi { get; set; }
        public String Gioi_Tinh { get; set; }
        public String SDT { get; set; }
        
    }
}

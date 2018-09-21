using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.DAL.Model
{
    public class SharedProvider
    {
        public DateTime Created { get; set; }
        public String CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public String ModifiedBy { get; set; }
        
    }
}

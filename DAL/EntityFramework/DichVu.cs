//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class DichVu
    {
        public System.Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten_Dich_Vu { get; set; }
        public Nullable<int> Don_Gia { get; set; }
        public string Don_Vi { get; set; }
        public string Quy_Tac_Tinh_Tien { get; set; }
        public string Mo_Ta { get; set; }
        public Nullable<System.Guid> Id_Nha_Tro { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}

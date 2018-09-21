using DAL.EntityFramework;
using QLPT.HUMG.BLL.IBusinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLPT.HUMG.Controllers
{
    public class KhachHangAPIController : ApiController
    {
       
        private IKhachHangService _khachHangService;
    
        public KhachHangAPIController(IKhachHangService khachHangService)
        {
            this._khachHangService = khachHangService;
        }
        [HttpGet]
        [Route("api/KhachHangAPI")]
        public IList<KhachHang> KhachHang_GetAll()
        {
            return this._khachHangService.KhachHang_GetAll().ToList();
        }

        public bool KhachHang_Insert(KhachHang khachHang)
        {
           return this._khachHangService.KhachHang_Insert(khachHang);
        }
        public bool KhachHang_Update(KhachHang khachHang)
        {
           return this._khachHangService.KhachHang_Update(khachHang);
        }
        public bool KhachHang_Delete(Guid Id)
        {
          return  this._khachHangService.KhachHang_Delete(Id);
        }
    }
}
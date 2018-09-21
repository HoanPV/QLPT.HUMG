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
    [RoutePrefix("api/DichVuAPI")]
    public class DichVuAPIController : ApiController
    {
       
        private IDichVuService _dichVuService;
    
        public DichVuAPIController(IDichVuService dichVuService)
        {
            this._dichVuService = dichVuService;
        }
        
        [Route("")]
        [HttpGet]
        public IList<DichVu> DichVu_GetAll()
        {
            return this._dichVuService.DichVu_GetAll().ToList();
        }

        public bool DichVu_Insert(DichVu dichVu)
        {
           return this._dichVuService.DichVu_Insert(dichVu);
        }
        public bool DichVu_Update(DichVu dichVu)
        {
           return this._dichVuService.DichVu_Update(dichVu);
        }
        public bool DichVu_Delete(Guid Id)
        {
          return  this._dichVuService.DichVu_Delete(Id);
        }
    }
}
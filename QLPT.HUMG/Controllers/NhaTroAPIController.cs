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
    [RoutePrefix("api/NhaTroAPI")]
    public class NhaTroAPIController : ApiController
    {
       
        private INhaTroService _nhaTroService;
    
        public NhaTroAPIController(INhaTroService nhaTroService)
        {
            this._nhaTroService = nhaTroService;
        }
        
        [Route("")]
        [HttpGet]
        public IList<NhaTro> NhaTro_GetAll()
        {
            return this._nhaTroService.NhaTro_GetAll().ToList();
        }

        public bool NhaTro_Insert(NhaTro nhatro)
        {
           return this._nhaTroService.NhaTro_Insert(nhatro);
        }
        public bool NhaTro_Update(NhaTro nhatro)
        {
           return this._nhaTroService.NhaTro_Update(nhatro);
        }
        public bool NhaTro_Delete(Guid Id)
        {
          return  this._nhaTroService.NhaTro_Delete(Id);
        }
    }
}

using DAL.EntityFramework;
using QLPT.HUMG.BLL.IBusinessService;
using QLPT.HUMG.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.HUMG.BLL.BusinessService
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository _khachHangRepository;
       
        public KhachHangService(IKhachHangRepository khachHangRepository)
        {
            _khachHangRepository = khachHangRepository;
        }
       
        public bool KhachHang_Delete(Guid Id)
        {
            try
            {
                _khachHangRepository.Delete(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        public IList<KhachHang> KhachHang_GetAll()
        {
            return _khachHangRepository.GetAll().ToList();
        }

        public KhachHang KhachHang_GetById(Guid Id)
        {
            return _khachHangRepository.GetById(Id);
        }
       
        public bool KhachHang_Insert(KhachHang khachHang)
        {
            try
            {
                _khachHangRepository.Create(khachHang);
                return true;
            }
            catch
            {
                return false;

            }
        }
     
        public bool KhachHang_Update(KhachHang khachHang)
        {
            try
            {
                _khachHangRepository.Update(khachHang);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

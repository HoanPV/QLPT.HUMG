
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
    public class DichVuService : IDichVuService
    {
        private readonly IDichVuRepository _dichVuRepository;
        /// <summary>
        /// DichVuService
        /// </summary>
        /// <param name="dichVuReppository"></param>
        public DichVuService(IDichVuRepository dichVuReppository)
        {
            _dichVuRepository = dichVuReppository;
        }
        /// <summary>
        /// DichVu_Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DichVu_Delete(Guid Id)
        {
            try
            {
                _dichVuRepository.Delete(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// DichVu_GetAll
        /// </summary>
        /// <returns></returns>
        public IList<DichVu> DichVu_GetAll()
        {
            return _dichVuRepository.GetAll().ToList();
        }
        /// <summary>
        /// DichVu_GetById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DichVu DichVu_GetById(Guid Id)
        {
            return _dichVuRepository.GetById(Id);
        }
        /// <summary>
        /// DichVu_Insert
        /// </summary>
        /// <param name="dichVu"></param>
        /// <returns></returns>
        public bool DichVu_Insert(DichVu dichVu)
        {
            try
            {
                _dichVuRepository.Create(dichVu);
                return true;
            }
            catch
            {
                return false;

            }
        }
        /// <summary>
        /// DichVu_Update
        /// </summary>
        /// <param name="dichVu"></param>
        /// <returns></returns>
        public bool DichVu_Update(DichVu dichVu)
        {
            try
            {
                _dichVuRepository.Update(dichVu);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

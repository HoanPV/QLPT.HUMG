
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
    public class PhongService : IPhongService
    {
        private readonly IPhongRepository _phongRepository;
        /// <summary>
        /// PhongService
        /// </summary>
        /// <param name="phongReppository"></param>
        public PhongService(IPhongRepository phongReppository)
        {
            _phongRepository = phongReppository;
        }
        /// <summary>
        /// Phong_Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Phong_Delete(Guid Id)
        {
            try
            {
                _phongRepository.Delete(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Phong_GetAll
        /// </summary>
        /// <returns></returns>
        public IList<Phong> Phong_GetAll()
        {
            return _phongRepository.GetAll().ToList();
        }
        /// <summary>
        /// Phong_GetById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Phong Phong_GetById(Guid Id)
        {
            return _phongRepository.GetById(Id);
        }
        /// <summary>
        /// Phong_Insert
        /// </summary>
        /// <param name="phong"></param>
        /// <returns></returns>
        public bool Phong_Insert(Phong phong)
        {
            try
            {
                _phongRepository.Create(phong);
                return true;
            }
            catch
            {
                return false;

            }
        }
        /// <summary>
        /// Phong_Update
        /// </summary>
        /// <param name="phong"></param>
        /// <returns></returns>
        public bool Phong_Update(Phong phong)
        {
            try
            {
                _phongRepository.Update(phong);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

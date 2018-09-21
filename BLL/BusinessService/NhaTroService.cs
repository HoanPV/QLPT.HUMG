
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
    public class NhaTroService : INhaTroService
    {
        private readonly INhaTroRepository _nhaTroRepository;
        /// <summary>
        /// NhaTroService
        /// </summary>
        /// <param name="NhaTroReppository"></param>
        public NhaTroService(INhaTroRepository NhaTroReppository)
        {
            _nhaTroRepository = NhaTroReppository;
        }
        /// <summary>
        /// NhaTro_Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool NhaTro_Delete(Guid Id)
        {
            try
            {
                _nhaTroRepository.Delete(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// NhaTro_GetAll
        /// </summary>
        /// <returns></returns>
        public IList<NhaTro> NhaTro_GetAll()
        {
            return _nhaTroRepository.GetAll().ToList();
        }
        /// <summary>
        /// NhaTro_GetById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public NhaTro NhaTro_GetById(Guid Id)
        {
            return _nhaTroRepository.GetById(Id);
        }
        /// <summary>
        /// NhaTro_Insert
        /// </summary>
        /// <param name="NhaTro"></param>
        /// <returns></returns>
        public bool NhaTro_Insert(NhaTro NhaTro)
        {
            try
            {
                _nhaTroRepository.Create(NhaTro);
                return true;
            }
            catch
            {
                return false;

            }
        }
        /// <summary>
        /// NhaTro_Update
        /// </summary>
        /// <param name="NhaTro"></param>
        /// <returns></returns>
        public bool NhaTro_Update(NhaTro NhaTro)
        {
            try
            {
                _nhaTroRepository.Update(NhaTro);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

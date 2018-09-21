using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IBusinessService
{
    public interface IGenericService<T>: IGenericRepository<T> where T:class
    {
    }
}

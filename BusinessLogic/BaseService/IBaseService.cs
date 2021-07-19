using BusinessLogic.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BaseService
{
    public interface IBaseService<T>: ICRUDService<T> where T: class
    {

    }
}

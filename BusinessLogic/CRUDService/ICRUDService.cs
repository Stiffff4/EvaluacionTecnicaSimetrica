using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface ICRUDService<T>: ICreateService<T>, IReadService<T>, IUpdateService<T>, IDeleteService<T> where T: class
    {
    }
}

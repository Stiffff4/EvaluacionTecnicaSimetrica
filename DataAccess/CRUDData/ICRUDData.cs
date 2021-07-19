using BusinessLogic.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CRUDData
{
    public interface ICRUDData<T>: ICreateData<T>, IReadData<T>, IUpdateData<T>, IDeleteData<T> where T: class
    {

    }
}

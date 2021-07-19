using DataAccess.CRUDData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BaseData
{
    public interface IBaseData<T>: ICRUDData<T> where T: class
    {

    }
}

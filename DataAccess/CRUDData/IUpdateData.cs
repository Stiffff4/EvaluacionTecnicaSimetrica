using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IUpdateData<T> where T: class
    {
        bool Update(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}

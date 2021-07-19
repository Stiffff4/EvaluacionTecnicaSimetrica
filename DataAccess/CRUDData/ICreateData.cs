using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface ICreateData<T> where T: class
    {
        bool Create(T entity);
        Task<bool> CreateAsync(T entity);
    }
}

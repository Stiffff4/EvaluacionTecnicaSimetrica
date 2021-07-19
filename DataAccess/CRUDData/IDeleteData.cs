using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IDeleteData<T> where T : class 
    {
        bool Delete(int id);
        Task<bool> DeleteAsync(int id);
    }
}

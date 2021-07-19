using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IReadData<T> where T : class
    {
        List<T> Get();
        T GetById(int id);
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(int id);
    }
}

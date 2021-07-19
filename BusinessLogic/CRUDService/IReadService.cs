using BusinessLogic.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IReadService<T> where T : class
    {
        IOperationResult Get();
        IOperationResult GetById(int id);
        Task<IOperationResult> GetAsync();
        Task<IOperationResult> GetByIdAsync(int id);
    }
}

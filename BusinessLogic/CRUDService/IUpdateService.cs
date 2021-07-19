using BusinessLogic.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IUpdateService<T> where T: class
    {
        IOperationResult Update(T entity);
        Task<IOperationResult> UpdateAsync(T entity);
    }
}

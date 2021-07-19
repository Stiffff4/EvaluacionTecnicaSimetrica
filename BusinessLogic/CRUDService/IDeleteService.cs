using BusinessLogic.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface IDeleteService<T> where T : class 
    {
        IOperationResult Delete(int id);
        Task<IOperationResult> DeleteAsync(int id);
    }
}

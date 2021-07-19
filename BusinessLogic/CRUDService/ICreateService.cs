using BusinessLogic.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CRUDService
{
    public interface ICreateService<T> where T: class
    {
        IOperationResult Create(T entity);
        Task<IOperationResult> CreateAsync(T entity);
    }
}

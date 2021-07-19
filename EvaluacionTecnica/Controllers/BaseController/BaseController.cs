using BusinessLogic.BaseService;
using BusinessLogic.OperationResult;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Controllers.BaseController
{
    public class BaseController<T> : ControllerBase where T: class
    {
        private readonly IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet, Route("Base_Get")]
        public virtual IOperationResult Get()
        {
            return _baseService.Get();
        }

        [HttpGet, Route("Base_GetById")]
        public virtual IOperationResult GetById(int id)
        {
            return _baseService.GetById(id);
        }

        [HttpGet, Route("Base_GetAsync")]
        public virtual async Task<IOperationResult> GetAsync()
        {
            return await _baseService.GetAsync();
        }

        [HttpGet, Route("Base_GetByIdAsync")]
        public virtual async Task<IOperationResult> GetByIdAsync(int id)
        {
            return await _baseService.GetByIdAsync(id);
        }

        [HttpPost, Route("Base_Create")]
        public virtual IOperationResult Create(T entity)
        {
            return _baseService.Create(entity);
        }

        [HttpPost, Route("Base_CreateAsync")]
        public virtual async Task<IOperationResult> CreateAsync(T entity)
        {
            return await _baseService.CreateAsync(entity);
        }

        [HttpPut, Route("Base_Update")]
        public virtual IOperationResult Update(T entity)
        {
            return _baseService.Update(entity);
        }

        [HttpPut, Route("Base_UpdateAsync")]
        public virtual async Task<IOperationResult> UpdateAsync(T entity)
        {
            return await _baseService.UpdateAsync(entity);
        }

        [HttpDelete, Route("Base_Delete")]
        public virtual IOperationResult Delete(int id)
        {
            return _baseService.Delete(id);
        }

        [HttpDelete, Route("Base_DeleteAsync")]
        public virtual async Task<IOperationResult> DeleteAsync(int id)
        {
            return await _baseService.DeleteAsync(id);
        }
    }
}

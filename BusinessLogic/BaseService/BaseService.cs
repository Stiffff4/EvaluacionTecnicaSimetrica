using BusinessLogic.OperationResult;
using BusinessLogic.Validation;
using DataAccess.BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BaseService
{
    public class BaseService<T>: IBaseService<T> where T: class
    {
        private readonly IOperationResult _op;
        private readonly IBaseData<T> _bd;
        private readonly IValidation<T> _validation;
        public BaseService(IOperationResult op, IBaseData<T> bd, IValidation<T> validation)
        {
            _op = op;
            _bd = bd;
            _validation = validation;
        }

        #region Create
        public virtual IOperationResult Create(T entity)
        {
            try
            {
                if (!_validation.Validate(entity))
                {
                    throw new Exception("Invalid model");
                }

                _op.GetSuccessOperation(_bd.Create(entity));
                _op.status = HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }

        public async virtual Task<IOperationResult> CreateAsync(T entity)
        {
            try
            {
                if (!_validation.Validate(entity))
                {
                    throw new Exception("Invalid model");
                }

                _op.GetSuccessOperation(await _bd.CreateAsync(entity));
                _op.status = HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }
        #endregion

        #region Read

        public virtual IOperationResult Get()
        {
            try
            {
                _op.GetSuccessOperation(_bd.Get());
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }
        public virtual IOperationResult GetById(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid id");
                }

                _op.GetSuccessOperation(_bd.GetById(id));
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }
        public async virtual Task<IOperationResult> GetAsync()
        {
            try
            {
                _op.GetSuccessOperation(await _bd.GetAsync());
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }
        public async virtual Task<IOperationResult> GetByIdAsync(int id)
        {
            {
                try
                {
                    if (id == 0)
                    {
                        throw new Exception("Invalid id");
                    }

                    _op.GetSuccessOperation(await _bd.GetByIdAsync(id));
                }
                catch (Exception e)
                {
                    _op.GetErrorOperation(e);
                }

                return _op;
            }
        }

        #endregion

        #region Update
        public virtual IOperationResult Update(T entity)
        {
            try
            {
                if (!_validation.Validate(entity))
                {
                    throw new Exception("Invalid model");
                }

                _op.GetSuccessOperation(_bd.Update(entity));
            }

            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }
        public async virtual Task<IOperationResult> UpdateAsync(T entity)
        {
            try
            {
                if (!_validation.Validate(entity))
                {
                    throw new Exception("Invalid model");
                }

                _op.GetSuccessOperation(await _bd.UpdateAsync(entity));
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }

        #endregion

        #region Delete

        public virtual IOperationResult Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid id");
                }

                _op.GetSuccessOperation(_bd.Delete(id));
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }

        public async virtual Task<IOperationResult> DeleteAsync(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("Invalid id");
                }

                _op.GetSuccessOperation(await _bd.DeleteAsync(id));
            }
            catch (Exception e)
            {
                _op.GetErrorOperation(e);
            }

            return _op;
        }

        #endregion
    }
}

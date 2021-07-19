using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.BaseData
{
    public class BaseData<T> : IBaseData<T> where T : class
    {
        private readonly EvaluacionTecnicaContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseData(EvaluacionTecnicaContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        #region Create
        public virtual bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
    
        public async virtual Task<bool> CreateAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        #endregion

        #region Read

        public virtual List<T> Get()
        {
            try
            {
                return _dbSet.ToList();
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
        public virtual T GetById(int id)
        {
            try
            {
                return _dbSet.Find(id);
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
        public async virtual Task<List<T>> GetAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
        public async virtual Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        #endregion

        #region Update

        public virtual bool Update(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
        public async virtual Task<bool> UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        #endregion

        #region Delete
        public virtual bool Delete(int id)
        {
            try
            {
                var entity = _dbSet.Find(id);
                if (entity == null)
                    throw new Exception($"The record with the id {id} does not exist.");

                _context.Remove(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
        public async virtual Task<bool> DeleteAsync(int id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity == null)
                    throw new Exception($"The record with the id {id} does not exist.");

                _context.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        #endregion
    }
}

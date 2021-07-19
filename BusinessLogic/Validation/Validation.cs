using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validation
{
    public class Validation<T> : IValidation<T> where T : class
    {
        public bool Validate(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new Exception("The entity is null");
                }

                if (entity.GetType().GetProperties()
                        .Where(x => x.Name != "id")
                        .Select(x => x.GetValue(entity) == null ? throw new Exception("One of the fields' values are null") : x.GetValue(entity).ToString())
                        .Any(x => string.IsNullOrWhiteSpace(x)))
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }
    }
}

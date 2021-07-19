using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validation
{
    public interface IValidation<T> where T: class
    {
        bool Validate(T entity);
    }
}

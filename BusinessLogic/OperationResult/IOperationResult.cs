using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.OperationResult
{
    public interface IOperationResult: ICloneable
    {
        bool isSuccess { get; }
        object result { get; set; }
        object error { get; set; }
        HttpStatusCode status { get; set; }
        void GetSuccessOperation(Object result);
        void GetErrorOperation(Exception message, HttpStatusCode status = HttpStatusCode.InternalServerError, bool IsWarning = false);
    }
}

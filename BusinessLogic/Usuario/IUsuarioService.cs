using BusinessLogic.BaseService;
using BusinessLogic.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Usuario
{
    public interface IUsuarioService: IBaseService<Database.Models.Usuario>
    {
        IOperationResult SignIn(string username, string password);
    }
}

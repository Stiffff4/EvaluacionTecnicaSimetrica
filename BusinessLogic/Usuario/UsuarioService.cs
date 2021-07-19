using BusinessLogic.BaseService;
using BusinessLogic.OperationResult;
using BusinessLogic.Validation;
using DataAccess.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Usuario
{
    public class UsuarioService: BaseService<Database.Models.Usuario>, IUsuarioService
    {
        private readonly IOperationResult _operationResult;
        private readonly IUsuarioData _usuarioData;
        private readonly IValidation<Database.Models.Usuario> _validation;
        public UsuarioService(
            IOperationResult operationResult, IUsuarioData usuarioData, IValidation<Database.Models.Usuario> validation) 
            : base(operationResult, usuarioData, validation)
        {
            _operationResult = operationResult;
            _usuarioData = usuarioData;
            _validation = validation;
        }

        public IOperationResult SignIn(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("Invalid username or password.");
                }

                _operationResult.GetSuccessOperation(_usuarioData.SignIn(username, password));
            }
            catch (Exception e)
            {
                _operationResult.GetErrorOperation(e);
            }

            return _operationResult;
        }
    }
}

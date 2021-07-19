using BusinessLogic.BaseService;
using BusinessLogic.OperationResult;
using BusinessLogic.Validation;
using DataAccess.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Role
{
    public class RoleService: BaseService<Database.Models.Roles>, IRoleService
    {
        private readonly IOperationResult _operationResult;
        private readonly IRoleData _roleData;
        private readonly IValidation<Database.Models.Roles> _validation;

        public RoleService(
            IOperationResult operationResult, IRoleData roleData, IValidation<Database.Models.Roles> validation)
            : base(operationResult, roleData, validation)
        {
            _operationResult = operationResult;
            _roleData = roleData;
            _validation = validation;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvaluacionTecnica.Controllers.BaseController;
using BusinessLogic.OperationResult;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Database.Models;

namespace EvaluacionTecnica.Controllers.Role
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<Roles>
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
            : base(roleService)
        {
            _roleService = roleService;
        }

        [Route("Create")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> CreateRole([FromBody] Roles model)
        {
            return await base.CreateAsync(model);
        }

        [HttpGet, Route("Get")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> GetAllRoles()
        {
            return await base.GetAsync();
        }

        [Route("Update")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> UpdateRole([FromBody] Roles model)
        {
            return await base.UpdateAsync(model);
        }

        [Route("Delete")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> DeleteRole(int id)
        {
            return await base.DeleteAsync(id);
        }
    }
}

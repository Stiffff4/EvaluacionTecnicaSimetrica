using BusinessLogic.OperationResult;
using BusinessLogic.Usuario;
using EvaluacionTecnica.Controllers.BaseController;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController<Database.Models.Usuario>
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet, Route("Get")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> GetAllUsers()
        {
            return await base.GetAsync();
        }

        [HttpPut, Route("Update")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> UpdateUser([FromBody] Database.Models.Usuario model)
        {
            return await base.UpdateAsync(model);
        }

        [HttpDelete, Route("Delete")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IOperationResult> DeleteUser(int id)
        {
            return await base.DeleteAsync(id);
        }
    }
}

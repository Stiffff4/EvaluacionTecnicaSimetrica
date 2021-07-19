using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Database.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using BusinessLogic.Usuario;
using System.Net;
using BusinessLogic.OperationResult;

namespace EvaluacionTecnica.Controllers.Account
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuarioService _usuarioService;
        private readonly IOperationResult _operationResult;
        public AccountController(IConfiguration configuration, IUsuarioService usuarioService, IOperationResult operationResult)
        {
            _configuration = configuration;
            _usuarioService = usuarioService;
            _operationResult = operationResult;
        }

        [HttpPost, Route("Register")]
        public async Task<IOperationResult> CreateUser([FromBody] Database.Models.Usuario user)
        {
            return await _usuarioService.CreateAsync(user);
        }

        [HttpPost, Route("Login")]
        public IActionResult Login([FromBody] Database.Models.Usuario user)
        {
            try
            {
                if (_usuarioService.SignIn(user.Usuario_Nombre, user.Contrasena).isSuccess)
                {
                    return BuildToken(user);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.GetBaseException().Message);
            }

            ModelState.AddModelError("Error", "Invalid login attempt.");
            return BadRequest(ModelState);
        }

        private IActionResult BuildToken(Database.Models.Usuario user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Usuario_Nombre),
                new Claim("miValor", "Lo que yo quiera"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Llave_super_secreta"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddHours(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: "yourdomain.com",
               audience: "yourdomain.com",
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = expiration
            });
        }
    }
}

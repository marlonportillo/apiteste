using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using api_prueba.DAO.Interfaces;
using api_prueba.Model;
using api_prueba.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace api_prueba.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosDAO usuariosDAO;
        private readonly IConfiguration _configuration;

        public UsuariosController(UsuariosDAO usuarios, IConfiguration configuration)
        {
            usuariosDAO = usuarios;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] Usuarios _usuario)
        {
            Result result = new Result();

            try
            {
                IEnumerable<Usuarios> usuariosList = usuariosDAO.getAll();
                result.Resultado = 1;
                result.Mensaje = "Data Obtenida";
                result.Datos = usuariosList;
                return Ok( result);
            }
            catch(Exception ex)
            {
                result.Resultado = 0;
                result.Mensaje = ex.Message;

                return Ok(result);

            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] Usuarios _usuario)
        {
            Result result = new Result();

            try
            {
                Usuarios usuariosList = usuariosDAO.login(_usuario);

                if (usuariosList != null)
                {
                    result.Resultado = 1;
                    result.Mensaje = "Data Obtenida";
                    result.Datos = usuariosList;
                    var secretKey = _configuration.GetValue<string>("SecretKey");
                    var key = Encoding.ASCII.GetBytes(secretKey);

                   
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, usuariosList.Usuario),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };
                    var tokenDescriptor = new JwtSecurityToken
                    (
                         claims : claims,
                        // Nuestro token va a durar un día
                        expires : DateTime.UtcNow.AddDays(1),
                        // Credenciales para generar el token usando nuestro secretykey y el algoritmo hash 256
                        signingCredentials : new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    );

                    var tokenHandler = new JwtSecurityTokenHandler();
                    

                    var retorno = tokenHandler.WriteToken(tokenDescriptor);
                    result.Token = retorno;

                    return Ok(result);
                }
                else
                {
                    result.Resultado = 0;
                    result.Mensaje = "Verifique si las credenciales son correctas";
                    result.Datos = usuariosList;
                    return Ok(result);
                }
                
            }
            catch (Exception ex)
            {
                result.Resultado = 0;
                result.Datos = null;
                result.Mensaje = ex.Message;

                return Ok(result);

            }
        }

    }
}
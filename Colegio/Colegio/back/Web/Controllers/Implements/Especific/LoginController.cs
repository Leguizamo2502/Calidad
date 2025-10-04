using Data.Implements.Pizza; 
using Entity.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : Controller
    {
        private readonly LoginData _loginService;

        public LoginController(LoginData loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Validar([FromBody] LoginDto loginDto)
        {
            var resultado = await _loginService.ValidarUsuario(loginDto);

            return Ok(resultado); 
        }
    }
}
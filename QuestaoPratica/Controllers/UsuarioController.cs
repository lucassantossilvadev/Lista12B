using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiJwt.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("perfil")]
        public IActionResult Perfil()
        {
            return Ok("Olá, " + User.Identity.Name + "! Você está autenticado.");
        }
    }
}
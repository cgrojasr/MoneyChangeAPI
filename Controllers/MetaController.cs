using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyChangeAPI.BussinesLogic;
using MoneyChangeAPI.Entities;

namespace MoneyChangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaController : ControllerBase
    {
        private readonly MetaBL metaBL;
        public MetaController(MetaBL _metaBL)
        {
            metaBL = _metaBL;
        }
        [HttpGet]
        public IActionResult BuscarPorId(int id_meta){
            try
            {
                return Ok(metaBL.BuscarPorId(id_meta));   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ListarPorUsuario")]
        public IActionResult ListarPorUsuario(string id_usuario){
            try
            {
                return Ok(metaBL.ListarPorUsuario(id_usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideosWebApi.Domain.DTO;
using VideosWebApi.Services;

namespace VideosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsavelsController : ControllerBase
    {
        private readonly ResponsavelService _responsavelService;

        public ResponsavelsController(ResponsavelService responsavelService)
        {
            _responsavelService = responsavelService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ResponsavelCreateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = await _responsavelService.Cadastrar(postModel);
                if (!retorno.Sucesso)
                    return BadRequest(retorno);
                else
                    return Ok(retorno.Conteudo);
            }
            else
                return BadRequest(ModelState);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAction(int id)
        {
            var retorno = await _responsavelService.PesquisarPorId(id);
            if(retorno.Sucesso)
                return Ok(retorno.Conteudo);
            else 
                return BadRequest(retorno);
        }
     }
}

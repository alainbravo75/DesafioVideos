using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideosWebApi.Domain.DTO;
using VideosWebApi.Services;

namespace VideosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaService _categoriaService;

        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var retorno = await _categoriaService.Pesquisar();
            if(retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var retorno = await _categoriaService.PesquisarPorId(id);
            if (retorno.Sucesso)
                return Ok(retorno.Conteudo);
            else
                return NotFound(retorno);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoriaCreateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = await _categoriaService.Cadastrar(postModel);
                if (!retorno.Sucesso)
                    return BadRequest(retorno);
                else
                    return Ok(retorno.Conteudo);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
     }
}

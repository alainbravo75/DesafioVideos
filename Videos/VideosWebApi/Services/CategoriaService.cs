using VideosWebApi.DAL.Repositories;
using VideosWebApi.Domain.DTO;
using VideosWebApi.Domain.Entity;
using VideosWebApi.Services.Base;

namespace VideosWebApi.Services
{
    public class CategoriaService
    {
        private readonly CategoriumRepository _categoriumRepository;
        public CategoriaService(CategoriumRepository categoriumRepository)
        {
            _categoriumRepository = categoriumRepository;
        }

        //Listar tudo
        public async Task<ServiceResponse<IEnumerable<CategoriaResponse>>> Pesquisar()
        {
            var listarCategoria = await _categoriumRepository.Pesquisar();

            var lista = listarCategoria.Select(categoria => new CategoriaResponse(categoria));
            return new ServiceResponse<IEnumerable<CategoriaResponse>>(lista);
        }

        //Listar Por Id
        public async Task<ServiceResponse<CategoriaCompletoResponse>> PesquisarPorId(int id)
        {
            var categoria = await _categoriumRepository.PesquisarPorId(id);
            if (categoria == null)
            {
                return new ServiceResponse<CategoriaCompletoResponse>("Não encontrado");
            }
            return new ServiceResponse<CategoriaCompletoResponse>(new CategoriaCompletoResponse(categoria));
        }
        //cadastrar co POST
        public async Task<ServiceResponse<CategoriaResponse>> Cadastrar(CategoriaCreateRequest novo)
        {
            var novaCategoria = new Categorium()
            {
                IdCategoria = novo.IdCategoria,
                NomeCategoria = novo.NomeCategoria
            };
            await _categoriumRepository.Cadastrar(novaCategoria);
            return new ServiceResponse<CategoriaResponse>(new CategoriaResponse(novaCategoria));
        }
    }
}

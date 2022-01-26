using VideosWebApi.DAL.Repositories;
using VideosWebApi.Domain.DTO;
using VideosWebApi.Domain.Entity;
using VideosWebApi.Services.Base;

namespace VideosWebApi.Services
{
    public class ResponsavelService
    {
        private readonly ResponsavelRepository _responsavelRepository;
        public ResponsavelService(ResponsavelRepository responsavelRepository)
        {
            _responsavelRepository = responsavelRepository;
        }
        public async Task<ServiceResponse<ResponsavelResponse>> Cadastrar(ResponsavelCreateRequest request)
        {
            var novoResponsavel = new Responsavel()
            {
                IdResponsavel = request.IdResponsavel,
                NomeResponsavel = request.NomeResponsavel
            };
            await _responsavelRepository.Cadastrar(novoResponsavel);
            return new ServiceResponse<ResponsavelResponse>(new ResponsavelResponse(novoResponsavel));
        }
        //Get By Id
        public async Task<ServiceResponse<ResponsavelResponse>> PesquisarPorId(int id)
        {
            var responsavel = await _responsavelRepository.PesquisarPorId(id);
            if(responsavel == null)
            {
                return new ServiceResponse<ResponsavelResponse>("Responsavel não encontrado");
            }
            return new ServiceResponse<ResponsavelResponse>(new ResponsavelResponse(responsavel));
        }
    }
}

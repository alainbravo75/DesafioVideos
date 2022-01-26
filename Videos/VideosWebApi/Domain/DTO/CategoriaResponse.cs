using VideosWebApi.Domain.Entity;

namespace VideosWebApi.Domain.DTO
{
    public class CategoriaResponse
    {
        public CategoriaResponse(Categorium baseModel)
        {
            IdCategoria = baseModel.IdCategoria;
            NomeCategoria = baseModel.NomeCategoria;
        }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}

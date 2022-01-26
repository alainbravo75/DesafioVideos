using VideosWebApi.Domain.Entity;

namespace VideosWebApi.Domain.DTO
{
    public class CategoriaCompletoResponse: CategoriaResponse
    {
        public CategoriaCompletoResponse(Categorium categorium): base(categorium)
        {
            IdCategoria = categorium.IdCategoria;
            NomeCategoria = categorium.NomeCategoria;
        }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set;}
    }
}

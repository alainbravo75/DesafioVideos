using VideosWebApi.Domain.Entity;

namespace VideosWebApi.Domain.DTO
{
    public class ResponsavelResponse
    {
        public ResponsavelResponse(Responsavel baseModel)
        {
            IdResponsavel = baseModel.IdResponsavel;
            NomeResponsavel = baseModel.NomeResponsavel;
        }
        public int IdResponsavel { get; set; }
        public string NomeResponsavel { get; set; }
        
    }
}
  

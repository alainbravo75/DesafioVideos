using System.ComponentModel.DataAnnotations;

namespace VideosWebApi.Domain.DTO
{
    public class ResponsavelCreateRequest
    {
        [Required]
        public int IdResponsavel { get; set; }
        [Required]
        public string NomeResponsavel { get; set; }
    }
}

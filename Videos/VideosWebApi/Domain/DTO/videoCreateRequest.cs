using System.ComponentModel.DataAnnotations;

namespace VideosWebApi.Domain.DTO
{
    public class videoCreateRequest
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Url { get; set; }
        public byte? IdadeMinima { get; set; }

    }
}

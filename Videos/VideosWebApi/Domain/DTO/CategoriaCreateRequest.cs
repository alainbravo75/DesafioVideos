using System.ComponentModel.DataAnnotations;

namespace VideosWebApi.Domain.DTO
{
    public class CategoriaCreateRequest
    {
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCategoria { get; set; }

    }
}

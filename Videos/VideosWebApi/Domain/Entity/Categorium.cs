using System;
using System.Collections.Generic;

namespace VideosWebApi.Domain.Entity
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; } = null!;
    }
}

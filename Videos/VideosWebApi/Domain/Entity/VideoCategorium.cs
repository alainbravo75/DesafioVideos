using System;
using System.Collections.Generic;

namespace VideosWebApi.Domain.Entity
{
    public partial class VideoCategorium
    {
        public int IdVideo { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
        public virtual Video IdVideoNavigation { get; set; } = null!;
    }
}

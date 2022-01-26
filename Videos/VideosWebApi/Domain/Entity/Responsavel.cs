using System;
using System.Collections.Generic;

namespace VideosWebApi.Domain.Entity
{
    public partial class Responsavel
    {
        public Responsavel()
        {
            Videos = new HashSet<Video>();
        }

        public int IdResponsavel { get; set; }
        public string NomeResponsavel { get; set; } = null!;

        public virtual ICollection<Video> Videos { get; set; }
    }
}

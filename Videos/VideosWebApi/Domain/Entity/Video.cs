namespace VideosWebApi.Domain.Entity
{
    public partial class Video
    {
        public int IdVideo { get; set; }
        public string Url { get; set; } = null;
        public byte? IdadeMinima { get; set; }
        public int IdResponsavel { get; set; }
        public string TituloVideo { get; set; }
        public virtual Responsavel IdResponsavelNavegation { get; set; } = null;
    }
}

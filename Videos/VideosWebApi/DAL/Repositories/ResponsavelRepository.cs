using VideosWebApi.Domain.Entity;

namespace VideosWebApi.DAL.Repositories
{
    public class ResponsavelRepository
    {
        private readonly VideosContext _context;
        public ResponsavelRepository(VideosContext context)
        {
            _context = context;
        }
        public async Task<Responsavel> Cadastrar(Responsavel novo)
        {
            _context.Responsavels.Add(novo);
            await _context.SaveChangesAsync();
            return novo;
        }
        //Get
        public async Task<Responsavel> PesquisarPorId(int id)
        {
            return await _context.Responsavels.FindAsync(id);
        }
    }
}

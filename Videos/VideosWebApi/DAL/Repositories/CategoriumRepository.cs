using Microsoft.EntityFrameworkCore;
using VideosWebApi.Domain.Entity;

namespace VideosWebApi.DAL.Repositories
{
    public class CategoriumRepository
    {
        private readonly VideosContext _context;
        public CategoriumRepository(VideosContext context)
        {
            _context = context;
        }
        public async Task<List<Categorium?>> Pesquisar()
        {
            return await _context.Categoria.ToListAsync();
        }
        public async Task<Categorium?> PesquisarPorId(int id)
        {
            // select top 1 * from Customers where id = :id
            return await _context.Categoria.FindAsync(id);
        }
        public async Task<Categorium> Cadastrar(Categorium nova)
        {
            _context.Categoria.Add(nova);
            await _context.SaveChangesAsync();
            return nova;
        }
    }
}

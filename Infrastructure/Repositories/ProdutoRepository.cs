using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class ProdutoRepository: BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

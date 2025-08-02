using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class ProdutoCosifRepository: BaseRepository<ProdutoCosif>, IProdutoCosifRepository
    {
        public ProdutoCosifRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

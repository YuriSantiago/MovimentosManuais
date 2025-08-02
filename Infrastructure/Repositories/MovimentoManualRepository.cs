using Contracts.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovimentoManualRepository: BaseRepository<MovimentoManual>, IMovimentoManualRepository
    {
        public MovimentoManualRepository(ApplicationDbContext context) : base(context)
        {
        }   

        public async Task<IList<MovimentoManualDTO>> ObterMovimentosAsync()
        {
            return await _context.MovimentosManuaisDTO
                .FromSqlRaw("EXEC SP_CONSULTA_MOVIMENTO_MANUAL")
                .AsNoTracking()
                .ToListAsync();
        }

    }
}

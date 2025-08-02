using Contracts.DTOs;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMovimentoManualRepository : IRepository<MovimentoManual>
    {

        Task<IList<MovimentoManualDTO>> ObterMovimentosAsync();

    }
}

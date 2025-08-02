using Contracts.DTOs;
using Contracts.Requests;
using Contracts.ViewModels;

namespace Application.Interfaces
{
    public interface IMovimentoManualService
    {
        Task<IList<MovimentoManualViewModel>> ObterMovimentosAsync();

        Task CriarMovimentoAsync(MovimentoManualRequest movimentoManualRequest);
    }
}

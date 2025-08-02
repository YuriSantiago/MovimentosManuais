using Contracts.ViewModels;

namespace Application.Interfaces
{
    public interface IProdutoService
    {
        Task<IList<ProdutoViewModel>> ObterProdutosAsync();

    }
}

using Contracts.ViewModels;

namespace Application.Interfaces
{
    public interface IProdutoCosifService
    {
        Task<IList<ProdutoCosifViewModel>> ObterProdutosCosifPorCodProdutoAsync(string codProduto);

    }
}

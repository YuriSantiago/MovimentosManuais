using Application.Interfaces;
using Contracts.ViewModels;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProdutoCosifService : IProdutoCosifService
    {
        private readonly IProdutoCosifRepository _produtoCosifRepository;

        public ProdutoCosifService(IProdutoCosifRepository produtoCosifRepository)
        {
            _produtoCosifRepository = produtoCosifRepository;
        }

        public async Task<IList<ProdutoCosifViewModel>> ObterProdutosCosifPorCodProdutoAsync(string codProduto)
        {
            var produtosCosif = await _produtoCosifRepository.GetAll();

            return produtosCosif.Where(pc => pc.CodProduto == codProduto).Select(pc => new ProdutoCosifViewModel
            {
                CodCosif = pc.CodCosif,
                CodClassificacao = pc.CodClassificacao
            }).ToList();

        }

    }
}

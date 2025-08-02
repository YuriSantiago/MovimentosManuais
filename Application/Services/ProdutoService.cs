using Application.Interfaces;
using Contracts.ViewModels;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IList<ProdutoViewModel>> ObterProdutosAsync()
        {
            var produtos = await _produtoRepository.GetAll();

            return produtos.Where(p => p.StaStatus == "A").Select(p => new ProdutoViewModel
            {
                CodProduto = p.CodProduto,
                DesProduto = p.DesProduto
            }).ToList();
        }

    }
}

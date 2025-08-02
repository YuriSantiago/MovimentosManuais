using Application.Interfaces;
using Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MovimentoManualController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IProdutoCosifService _produtoCosifService;
        private readonly IMovimentoManualService _movimentoManualService;

        public MovimentoManualController(IProdutoService produtoService, IProdutoCosifService produtoCosifService, IMovimentoManualService movimentoManualService)
        {
            _produtoService = produtoService;
            _produtoCosifService = produtoCosifService;
            _movimentoManualService = movimentoManualService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var produtosViewModel = await _produtoService.ObterProdutosAsync();
            var movimentosManuaisViewModel = await _movimentoManualService.ObterMovimentosAsync();

            ViewBag.Produtos = produtosViewModel;

            return View(movimentosManuaisViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovimentoManualRequest movimentoManualRequest)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            await _movimentoManualService.CriarMovimentoAsync(movimentoManualRequest);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetProdutosCosif(string codProduto)
        {
            var cosifs = await _produtoCosifService.ObterProdutosCosifPorCodProdutoAsync(codProduto);
            return Json(cosifs);
        }

    }
}

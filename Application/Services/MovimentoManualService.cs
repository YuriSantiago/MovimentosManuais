using Application.Interfaces;
using Contracts.Requests;
using Contracts.ViewModels;
using Domain.Entities;
using Domain.Interfaces;
using System.Data;

namespace Application.Services
{
    public class MovimentoManualService : IMovimentoManualService
    {
        private readonly IMovimentoManualRepository _movimentoManualRepository;

        public MovimentoManualService(IMovimentoManualRepository movimentoManualRepository)
        {
            _movimentoManualRepository = movimentoManualRepository;
        }

        public async Task<IList<MovimentoManualViewModel>> ObterMovimentosAsync()
        {
            var movimentosManuaisDTO = await _movimentoManualRepository.ObterMovimentosAsync();

            return movimentosManuaisDTO.Select(m => new MovimentoManualViewModel
            {
                DatMes = m.DatMes,
                DatAno = m.DatAno,
                CodProduto = m.CodProduto,
                DesProduto = m.DesProduto,
                NumLancamento = m.NumLancamento,
                DesDescricao = m.DesDescricao,
                ValValor = m.ValValor
            }).ToList();
        }

        public async Task CriarMovimentoAsync(MovimentoManualRequest movimentoManualRequest)
        {
            var movimentoManual = new MovimentoManual
            {
                DatMes = movimentoManualRequest.DatMes,
                DatAno = movimentoManualRequest.DatAno,
                NumLancamento = await ObterProximoNumeroLancamento(movimentoManualRequest.DatAno, movimentoManualRequest.DatMes),
                CodProduto = movimentoManualRequest.CodProduto,
                CodCosif = movimentoManualRequest.CodCosif,
                ValValor = movimentoManualRequest.ValValor,
                DesDescricao = movimentoManualRequest.DesDescricao,
                DatMovimento = DateTime.Now,
                CodUsuario = movimentoManualRequest.CodUsuario
            };

            await _movimentoManualRepository.Create(movimentoManual);
        }

        private async Task<int> ObterProximoNumeroLancamento(int ano, int mes)
        {
            var movimentosManuais = await _movimentoManualRepository.GetAll();

            var numLancamento = movimentosManuais
                .Where(m => m.DatAno == ano && m.DatMes == mes)
                .Max(m => (int?)m.NumLancamento) ?? 0;

            return numLancamento + 1;
        }
    }
}

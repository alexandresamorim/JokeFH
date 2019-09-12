using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JokeFH.Aplicacao.Interface;
using JokeFH.Aplicacao.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JokeFH.Web.Controllers
{
    [Route("api/[controller]")]
    public class HistoricoController : Controller
    {
        private readonly IHistoricoAppService _historicoAppService;

        public HistoricoController(IHistoricoAppService historicoAppService)
        {
            _historicoAppService = historicoAppService;
        }

        [AllowAnonymous]
        [HttpGet("ObterJogosPorJogador/{jogador}")]
        public IEnumerable<HistoricoViewModel> ObterJogosPorJogador(string jogador)
        {
            var historicos = _historicoAppService.ObterPorJogador(jogador).OrderBy(t=> t.DataHora);
            return historicos;
        }

        [AllowAnonymous]
        [HttpPost("Adicionar")]
        public IActionResult Adicionar([FromBody] HistoricoViewModel historicoView)
        {
            
            _historicoAppService.Adicionar(historicoView);

            return Ok(new
            {
                success = true,
                data = "Registro gravado com sucesso."
            });
        }
    }
}
using Kondominium.Domain.CommandsModels.Condominio;
using Kondominium.Domain.CommandsServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kondominium.API.Controllers
{
    [Route("Kondominium/Condominio")]
    public class CondominioController : BaseController
    {
        private CondominioListService _condominioListService;
        private CondominioSaveService _condominioSaveService;

        public CondominioController(CondominioListService condominioListService, CondominioSaveService condominioSaveService)
        {
            _condominioListService = condominioListService;
            _condominioSaveService = condominioSaveService;
        }

        [HttpGet]
        [Route("Listar")]
        [AllowAnonymous]
        public IActionResult Listar()
        {
            return Ok(_condominioListService.Listar());
        }

        [HttpPost]
        [Route("Salvar")]
        [AllowAnonymous]
        public IActionResult Salvar([FromBody]CondominioSaveCommand condominioSaveCommand)
        {
            condominioSaveCommand = _condominioSaveService.Salvar(condominioSaveCommand);

            return Response(condominioSaveCommand, condominioSaveCommand.GetNotifications());
            
        }

        [HttpPost]
        [Route("Deletar")]
        [AllowAnonymous]
        public IActionResult Deletar(int idCondominio)
        {
            var condominioSaveCommand = _condominioSaveService.Excluir(idCondominio);

            return Response(condominioSaveCommand, condominioSaveCommand.GetNotifications());

        }

        [HttpGet]
        [Route("Recuperar")]
        [AllowAnonymous]
        public IActionResult Recuperar(int idCondominio)
        {
            var condominioResultCommand = _condominioListService.Get(idCondominio);

            return Ok(condominioResultCommand);

        }
    }
}
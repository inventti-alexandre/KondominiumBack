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
        [Route("ListarCondominio")]
        [AllowAnonymous]
        public IActionResult ListarCondominio()
        {
            return Ok(_condominioListService.List());
        }

        [HttpPost]
        [Route("SalvarCondominio")]
        [AllowAnonymous]
        public IActionResult SalvarCondominio([FromBody]CondominioSaveCommand condominioSaveCommand)
        {
            condominioSaveCommand = _condominioSaveService.Save(condominioSaveCommand);

            return Response(condominioSaveCommand, condominioSaveCommand.GetNotifications());
            
        }
    }
}
using Kondominium.Domain.CommandsModels.Condominio;
using Kondominium.Domain.Interfaces.Commands;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class CondominioListService : ICommandList<CondominioListarCommand>
    {
        private readonly ICondominioRepository _condominioRepository;

        public CondominioListService(ICondominioRepository condominioRepository)
        {
            _condominioRepository = condominioRepository;
        }

        public List<CondominioListarCommand> List()
        {
            var condominios = _condominioRepository.List();

            var condominioListarCommand = condominios.Select(x => new CondominioListarCommand(x.Nome, x.Rua, x.CEP, x.Complemento, x.Cidade, x.Estado)).ToList();

            return condominioListarCommand;
        }
    }
}

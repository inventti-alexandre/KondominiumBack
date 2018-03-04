using Kondominium.Domain.CommandsModels.Condominio;

using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class CondominioListService
    {
        private readonly ICondominioRepository _condominioRepository;

        public CondominioListService(ICondominioRepository condominioRepository)
        {
            _condominioRepository = condominioRepository;
        }

        public List<CondominioListarCommand> Listar()
        {
            var condominios = _condominioRepository.Listar();

            var condominioListarCommand = condominios.Select(x => new CondominioListarCommand(x.Nome, x.Rua, x.CEP, x.Complemento, x.Cidade, x.Estado)).ToList();

            return condominioListarCommand;
        }

        public CondominioListarCommand Get(int idCondominio)
        {
            var condominio = _condominioRepository.RecuperarPorId(idCondominio);

            if (condominio != null)
            {
                var condominioListarCommand = new CondominioListarCommand(condominio.Nome, condominio.Rua, condominio.CEP, condominio.Complemento, condominio.Cidade, condominio.Estado);

                return condominioListarCommand;
            }

            return null;
        }
    }
}

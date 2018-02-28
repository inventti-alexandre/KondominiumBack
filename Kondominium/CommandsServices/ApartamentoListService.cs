using Kondominium.Domain.CommandsModels.Apartamento;
using Kondominium.Domain.Interfaces.Commands;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class ApartamentoListService : ICommandList<ApartamentoListarCommand>
    {
        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentoListService(IApartamentoRepository apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
        }

        public List<ApartamentoListarCommand> List()
        {
            var apartamentos = _apartamentoRepository.List();

            var apartamentoListarCommand = apartamentos.Select(x => new ApartamentoListarCommand(x.Numero, x.Bloco.Nome)).ToList();

            return apartamentoListarCommand;
        }
    }
}

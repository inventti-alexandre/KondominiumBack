using Kondominium.Domain.CommandsModels.Bloco;
using Kondominium.Domain.Interfaces.Commands;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class BlocoListService : ICommandList<BlocoListarCommand>
    {
        private readonly IBlocoRepository _BlocoRepository;

        public BlocoListService(IBlocoRepository BlocoRepository)
        {
            _BlocoRepository = BlocoRepository;
        }

        public List<BlocoListarCommand> List()
        {
            var Blocos = _BlocoRepository.List();

            return null;
        }
    }
}

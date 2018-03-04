using Kondominium.Domain.CommandsModels.Bloco;

using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class BlocoListService 
    {
        private readonly IBlocoRepository _BlocoRepository;

        public BlocoListService(IBlocoRepository BlocoRepository)
        {
            _BlocoRepository = BlocoRepository;
        }

        public List<BlocoListarCommand> Listar()
        {
            var Blocos = _BlocoRepository.Listar();

            return null;
        }
    }
}

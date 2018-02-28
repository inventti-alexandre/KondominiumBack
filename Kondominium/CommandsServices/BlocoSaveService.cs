using Kondominium.Domain.CommandsModels.Bloco;
using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Commands;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsServices
{
    public class BlocoSaveService : ICommandSave<BlocoSaveCommnad>
    {
        private readonly IBlocoRepository _blocoRepository;

        public BlocoSaveService(IBlocoRepository blocoRepository)
        {
            _blocoRepository = blocoRepository;
        }

        public void Save(BlocoSaveCommnad condimonioSaveCommand)
        {
            var bloco = new Bloco(condimonioSaveCommand.Nome, new Condominio() { Id = condimonioSaveCommand.IdCondominio });
            
            _blocoRepository.Save(bloco);
        }
    }
}

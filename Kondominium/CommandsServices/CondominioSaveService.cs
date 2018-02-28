using Kondominium.Domain.CommandsModels.Condominio;
using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Commands;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsServices
{
    public class CondominioSaveService : ICommandSave<CondominioSaveCommand>
    {
        private readonly ICondominioRepository _condominioRepository;

        public CondominioSaveService(ICondominioRepository condominioRepository)
        {
            _condominioRepository = condominioRepository;
        }

        public void Save(CondominioSaveCommand condimonioSaveCommand)
        {
            var condominio = new Condominio(condimonioSaveCommand.Nome, condimonioSaveCommand.Rua, condimonioSaveCommand.CEP, condimonioSaveCommand.Complemento, condimonioSaveCommand.Cidade, condimonioSaveCommand.Estado);
            
            _condominioRepository.Save(condominio);
        }
    }
}

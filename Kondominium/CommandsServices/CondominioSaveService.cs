using Kondominium.Domain.CommandsModels.Condominio;
using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;

namespace Kondominium.Domain.CommandsServices
{
    public class CondominioSaveService 
    {
        private readonly ICondominioRepository _condominioRepository;

        public CondominioSaveService(ICondominioRepository condominioRepository)
        {
            _condominioRepository = condominioRepository;
        }

        public CondominioSaveCommand Save(CondominioSaveCommand condimonioSaveCommand)
        {

            if (condimonioSaveCommand.Valido())
            {
                var condominio = new Condominio(condimonioSaveCommand.Nome, condimonioSaveCommand.Rua, condimonioSaveCommand.CEP, condimonioSaveCommand.Complemento, condimonioSaveCommand.Cidade, condimonioSaveCommand.Estado);

                _condominioRepository.Save(condominio);

                condimonioSaveCommand.Id = condominio.Id;
            }

            return condimonioSaveCommand;
        }
    }
}

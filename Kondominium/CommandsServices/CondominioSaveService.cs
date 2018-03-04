using System;
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

        public CondominioSaveCommand Salvar(CondominioSaveCommand condimonioSaveCommand)
        {
            var condominio = new Condominio(condimonioSaveCommand.Nome, condimonioSaveCommand.Rua, condimonioSaveCommand.CEP, condimonioSaveCommand.Complemento, condimonioSaveCommand.Cidade, condimonioSaveCommand.Estado);
            
            if (condominio.Valido())
            {                
                _condominioRepository.Salvar(condominio);

                condimonioSaveCommand.Id = condominio.Id;
            }

            condimonioSaveCommand.AddNotification(condominio.GetNotifications());

            return condimonioSaveCommand;
        }

        public CondominioSaveCommand Excluir(int idCondominio)
        {
            var condominio = new Condominio()
            {
                Id = idCondominio,
                Excluido = true
            };

            _condominioRepository.Salvar(condominio);

            return new CondominioSaveCommand(); 
        }        
    }
}

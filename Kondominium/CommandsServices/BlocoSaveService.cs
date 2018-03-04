using Kondominium.Domain.CommandsModels.Bloco;
using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using System;


namespace Kondominium.Domain.CommandsServices
{
    public class BlocoSaveService 
    {
        private readonly IBlocoRepository _blocoRepository;

        public BlocoSaveService(IBlocoRepository blocoRepository)
        {
            _blocoRepository = blocoRepository;
        }

        public void Salvar(BlocoSalvarCommnad condimonioSaveCommand)
        {
            var bloco = new Bloco(condimonioSaveCommand.Nome, condimonioSaveCommand.IdCondominio);
            
            
            _blocoRepository.Salvar(bloco);
        }
    }
}

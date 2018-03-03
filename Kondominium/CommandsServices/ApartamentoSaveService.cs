
using Kondominium.Domain.CommandsModels.Apartamento;
using Kondominium.Domain.Entities;

using Kondominium.Domain.Interfaces.Repositories;

namespace Kondominium.Domain.CommandsServices
{
    public class ApartamentoSaveService 
    {
        private readonly IApartamentoRepository _repository;

        public ApartamentoSaveService(IApartamentoRepository repository)
        {
            _repository = repository;
        }

        public void Save(ApartarmentoSaveCommnad saveCommand)
        {
            var apartamento = new Apartamento(saveCommand.Nome, new Bloco() { Id = saveCommand.IdBloco }, new Usuario() { Id = saveCommand.IdUsuario });

            _repository.Save(apartamento);
        }
    }
}

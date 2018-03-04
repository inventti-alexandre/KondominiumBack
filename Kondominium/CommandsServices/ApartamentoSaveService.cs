
using Kondominium.Domain.CommandsModels.Apartamento;
using Kondominium.Domain.Entities;

using Kondominium.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Kondominium.Domain.CommandsServices
{
    public class ApartamentoSaveService 
    {
        private readonly IApartamentoRepository _repository;

        public ApartamentoSaveService(IApartamentoRepository repository)
        {
            _repository = repository;
        }

        public ApartamentoSalvarCommand Salvar(ApartamentoSalvarCommand apartamentoCommand)
        {           
            var apartamento = new Apartamento(apartamentoCommand.Numero, apartamentoCommand.IdBloco);

            if (apartamento.Valido())
            {
                _repository.Salvar(apartamento);
                apartamentoCommand.Id = apartamento.Id;
            }
            apartamentoCommand.AddNotification(apartamento.GetNotifications());

            return apartamentoCommand;
        }
    }
}

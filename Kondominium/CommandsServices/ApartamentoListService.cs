using Kondominium.Domain.CommandsModels.Apartamento;
using Kondominium.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kondominium.Domain.CommandsServices
{
    public class ApartamentoListService 
    {
        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentoListService(IApartamentoRepository apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
        }

        public List<ApartamentoListarCommand> Listar()
        {
            var apartamentos = _apartamentoRepository.Listar();

            var apartamentoListarCommand = apartamentos.Select(x => new ApartamentoListarCommand(x.Numero, x.Bloco.Nome)).ToList();

            return apartamentoListarCommand;
        }

        public List<ApartamentoListarCommand> ListarPorCondominio(int idCondominio)
        {
            var apartamentos = _apartamentoRepository.ListarPorCondominio(idCondominio);

            var apartamentoListarCommand = apartamentos.Select(x => new ApartamentoListarCommand(x.Numero, x.Bloco.Nome)).ToList();

            return apartamentoListarCommand;
        }

        public List<ApartamentoListarCommand> ListarPorBloco(int idBloco)
        {
            var apartamentos = _apartamentoRepository.ListarPorBloco(idBloco);

            var apartamentoListarCommand = apartamentos.Select(x => new ApartamentoListarCommand(x.Numero, x.Bloco.Nome)).ToList();

            return apartamentoListarCommand;
        }
    }
}

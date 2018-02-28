using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Apartamento
{
    public class ApartamentoListarCommand
    {
        public string Numero { get; set; }
        public string Bloco { get; set; }

        public ApartamentoListarCommand(string numero, string bloco)
        {
            Numero = numero;
            Bloco = bloco;

        }
    }
}

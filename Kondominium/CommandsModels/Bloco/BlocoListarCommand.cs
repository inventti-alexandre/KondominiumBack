using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Bloco
{
    public class BlocoListarCommand
    {
        public string Nome { get; set; }
        public string Condominio { get; set; }

        public BlocoListarCommand(string nome, string condominio)
        {
            Nome = nome;
            Condominio = condominio;

        }
    }
}

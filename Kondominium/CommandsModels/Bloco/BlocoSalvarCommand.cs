using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Bloco
{
    public class BlocoSaveCommnad
    {
        public string Nome { get; set; }
        public int IdCondominio { get; set; }

        public BlocoSaveCommnad(string nome, int idCondominio)
        {
            Nome = nome;
            IdCondominio = idCondominio;

        }
    }
}

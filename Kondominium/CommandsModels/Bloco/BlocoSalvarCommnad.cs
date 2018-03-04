using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Bloco
{
    public class BlocoSalvarCommnad : Notification.Notifications
    {
        public string Nome { get; set; }
        public int IdCondominio { get; set; }

        public BlocoSalvarCommnad(string nome, int idCondominio)
        {
            Nome = nome;
            IdCondominio = idCondominio;

        }
    }
}

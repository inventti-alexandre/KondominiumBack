using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Condominio
{
    public class CondominioSaveCommand : Notification.Notifications
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Cidade { get; set; }
        public int Estado { get; set; }

        public bool Valido()
        {
            if (string.IsNullOrEmpty(Nome))
                AddNotification("Nome Vazio.");

            if (string.IsNullOrEmpty(Rua))
                AddNotification("Rua Vazia.");

            if (string.IsNullOrEmpty(CEP))
                AddNotification("CEP Vazio.");

            if (string.IsNullOrEmpty(Complemento))
                AddNotification("Complemento Vazio.");

            return GetNotifications().Count == 0;
        }
    }
}

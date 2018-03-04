using Kondominium.Domain.CommandsModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Apartamento
{
    public class ApartamentoSalvarCommand : Notification.Notifications
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int IdBloco { get; set; }
        public List<UsuarioSalvarCommand> Usuarios { get; internal set; }
        
        public ApartamentoSalvarCommand(string nome, int idBloco, List<UsuarioSalvarCommand> usuarios)
        {
            Numero = nome;
            IdBloco = idBloco;
            Usuarios = usuarios;
        }

       
    }
}

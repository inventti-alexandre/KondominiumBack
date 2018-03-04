using Kondominium.Domain.CommandsModels.Apartamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Usuario
{
    public class UsuarioSalvarCommand : Notification.Notifications
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int? TipoDocumento { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public bool? Ativo { get; set; }
                   
        public bool? Sindico { get; set; }
        public bool? ViceSindico { get; set; }
                   
        public bool? Proprietario { get; set; }
        public bool? Inquilino { get; set; }
                   
        public bool? RepresentanteOficial { get; set; }
        public bool? Morador { get; set; }
        public bool? Funcionario { get; set; }
        public bool? Admininstrador { get; set; }

        public List<int> Condominios { get; set; }
        public List<ApartamentoSalvarCommand> Apartamentos { get; set; }

       
    }
}

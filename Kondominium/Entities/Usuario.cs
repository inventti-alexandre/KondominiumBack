using System.Collections.Generic;

namespace Kondominium.Domain.Entities
{
    public class Usuario : EnitidadeBase
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

        public bool Sindico { get; set; }
        public bool ViceSindico { get; set; }
        public bool Funcionario { get; set; }
        public bool Admininstrador { get; set; }

        public virtual ICollection<Condominio> Condominios { get; set; }

        public virtual ICollection<ApartamentoUsuario> Apartamentos { get; set; }

        public bool Valido()
        {
            if (string.IsNullOrEmpty(Nome))
                AddNotification("Nome Vazio.");

            if (string.IsNullOrEmpty(Login))
                AddNotification("Login Vazio.");
            if (string.IsNullOrEmpty(Documento))
                AddNotification("Documento Vazio.");
            if (string.IsNullOrEmpty(Senha))
                AddNotification("Senha Vazio.");
            if (string.IsNullOrEmpty(Email))
                AddNotification("Email Vazio.");
            if (string.IsNullOrEmpty(Telefone1))
                AddNotification("Telefone Principal Vazio.");
            if (TipoDocumento == null || TipoDocumento == 0)
                AddNotification("Tipo de Documento Vazio.");
                        
            return IsValid();
        }
    }
}
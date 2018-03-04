using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class Condominio : EnitidadeBase
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Cidade { get;  set; }
        public int Estado { get; set; }

        public Condominio()
        {

        }

        public Condominio(string nome, string rua, string cEP, string complemento, int cidade, int estado)
        {
            Nome = nome;
            Rua = rua;
            CEP = cEP;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
        }
        
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Bloco> Blocos { get; set; }

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

            return IsValid();
        }

    }
}

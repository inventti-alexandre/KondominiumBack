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

        

        public List<Bloco> Blocos { get; set; }
    }
}

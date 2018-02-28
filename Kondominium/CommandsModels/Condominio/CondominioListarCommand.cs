using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Condominio
{
    public class CondominioListarCommand
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Cidade { get; set; }
        public int Estado { get; set; }

        public CondominioListarCommand(string nome, string rua, string cEP, string complemento, int cidade, int estado)
        {
            Nome = nome;
            Rua = rua;
            CEP = cEP;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
        }
    }
}

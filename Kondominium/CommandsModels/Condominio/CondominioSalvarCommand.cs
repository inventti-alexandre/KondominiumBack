using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Condominio
{
    public class CondominioSaveCommand
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Cidade { get; set; }
        public int Estado { get; set; }
    }
}

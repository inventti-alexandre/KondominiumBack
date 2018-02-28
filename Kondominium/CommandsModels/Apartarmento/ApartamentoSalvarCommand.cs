using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Apartamento
{
    public class ApartarmentoSaveCommnad
    {
        public string Nome { get; set; }
        public int IdBloco { get; set; }
        public int IdUsuario { get; internal set; }

        public ApartarmentoSaveCommnad(string nome, int idBloco)
        {
            Nome = nome;
            IdBloco = idBloco;

        }
    }
}

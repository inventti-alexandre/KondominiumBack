using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class Bloco : EnitidadeBase
    {
        public string Nome { get; set; }

        public Condominio Condominio { get; set; }
        
        public Bloco(string nome, Condominio condominio)
        {
            Nome = nome;
            Condominio = condominio;
        }

        public Bloco()
        {
            
        }

       
    }
}

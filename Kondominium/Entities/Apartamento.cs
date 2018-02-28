using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class Apartamento: EnitidadeBase
    {
        public string Numero { get; set; }
        public Usuario Usuario { get; set; }
        public Bloco Bloco { get; set; }

        public Apartamento(string numero, Bloco bloco, Usuario usuario)
        {
            Numero = numero;
            Bloco = bloco;
            Usuario = usuario;
        }
        public Apartamento()
        {

        }

        
    }
}

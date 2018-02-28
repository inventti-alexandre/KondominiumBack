using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class Usuario : EnitidadeBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public bool Ativo { get; set; }
        
        public bool Sindico { get; set; }
        public bool ViceSindico { get; set; }

        public bool Proprietario { get; set; }
        public bool Inquilino { get; set; }

        public bool RepresentanteOficial { get; set; }
        public bool Morador { get; set; }
        public bool Funcionario { get; set; }
        public bool Admininstrador { get; set; }

        public List<Apartamento> Apartamentos { get; set; }
    }
}


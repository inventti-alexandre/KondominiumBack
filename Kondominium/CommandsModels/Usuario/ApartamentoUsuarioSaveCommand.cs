using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.CommandsModels.Usuario
{
    public class ApartamentoUsuarioSaveCommand : Entities.EnitidadeBase
    {
        public int ApartamentoId { get; set; }
        public int UsuarioId { get; set; }

        public bool Proprietario { get; set; }
        public bool Inquilino { get; set; }
        public bool RepresentanteOficial { get; set; }
        public bool Morador { get; set; }
        
        public ApartamentoUsuarioSaveCommand(int apartamentoId, int usuarioId, bool proprietario, bool inquilino, bool representanteOficial, bool morador)
        {
            ApartamentoId = apartamentoId;
            UsuarioId = usuarioId;
            Proprietario = proprietario;
            Inquilino = inquilino;
            RepresentanteOficial = representanteOficial;
            Morador = morador;
        }
    }
}

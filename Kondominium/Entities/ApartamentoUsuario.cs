namespace Kondominium.Domain.Entities
{
    public class ApartamentoUsuario : EnitidadeBase
    {
        public int ApartamentoId { get; set; }
        public int UsuarioId { get; set; }

        public bool Proprietario { get; set; }
        public bool Inquilino { get; set; }

        public bool RepresentanteOficial { get; set; }
        public bool Morador { get; set; }

        public Apartamento Apartamento { get; set; }
        public Usuario Usuario { get; set; }

        public ApartamentoUsuario(int apartamentoId, int usuarioId, bool proprietario, bool inquilino, bool representanteOficial, bool morador)
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

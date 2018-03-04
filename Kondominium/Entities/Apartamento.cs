using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class Apartamento: EnitidadeBase
    {
        public string Numero { get; set; }
        public List<ApartamentoUsuario> Usuarios { get; set; }
        public Bloco Bloco { get; set; }
        public int BlocoId { get; set; }
        

        public Apartamento(string numero, Bloco bloco, List<ApartamentoUsuario> usuarios)
        {
            Numero = numero;
            Bloco = bloco;
            Usuarios = usuarios;
        }

        public Apartamento(string numero, int blocoId)
        {
            Numero = numero;
            BlocoId = blocoId;
        }

        public Apartamento()
        {

        }

        public bool Valido()
        {
            if (string.IsNullOrEmpty(Numero))
                AddNotification("Nome Vazio.");

            if (BlocoId == 0)
                AddNotification("Bloco não informado.");

            if (Usuarios != null && Usuarios.Any())
                Usuarios.ForEach(x => AddNotification(x.GetNotifications()));

            return IsValid();
        }

    }
}

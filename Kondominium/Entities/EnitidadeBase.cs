using Kondominium.Domain.Notification;
using System;

namespace Kondominium.Domain.Entities
{
    public class EnitidadeBase : Notifications
    {
        public int Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Excluido { get; set; }
        
    }
}

using Kondominium.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Entities
{
    public class EnitidadeBase 
    {
        public int Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Excluido { get; set; }
        
    }
}

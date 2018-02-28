using Kondominium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Interfaces.Repositories
{
    public interface IBlocoRepository : IRepositoryBase<Bloco>
    {
        void Save(Bloco bloco);
    }
}

using Kondominium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Interfaces.Repositories
{
    public interface IApartamentoRepository : IRepositoryBase<Apartamento>
    {
        void Save(Apartamento apartamento);
    }
}

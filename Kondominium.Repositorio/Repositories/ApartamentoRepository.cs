using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(KondominiumContext kondominiumContext) : base(kondominiumContext)
        {
        }

        public void Save(Apartamento apartamento)
        {
            if (apartamento.Id == 0)
            {
                Insert(apartamento);
            }
            else
            {
                Update(apartamento);
            }
        }
    }
}

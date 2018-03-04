using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class CondominioRepository : RepositoryBase<Condominio>, ICondominioRepository
    {
        public CondominioRepository(KondominiumContext kondominiumContext) : base(kondominiumContext)
        {
        }

        public void Salvar(Condominio condominio)
        {
            if (condominio.Id == 0)
            {
                Inserir(condominio);
            }
            else
            {
                Atualizar(condominio);
            }
        }
    }
}

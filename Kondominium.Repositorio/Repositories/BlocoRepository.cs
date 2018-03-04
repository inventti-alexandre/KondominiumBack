using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class BlocoRepository : RepositoryBase<Bloco>, IBlocoRepository
    {
        public BlocoRepository(KondominiumContext kondominiumContext) : base(kondominiumContext)
        {
        }

        public void Salvar(Bloco bloco)
        {
            if (bloco.Id == 0)
            {
                Inserir(bloco);
            }
            else
            {
                Atualizar(bloco);
            }
        }
    }
}

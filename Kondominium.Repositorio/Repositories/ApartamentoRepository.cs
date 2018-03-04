using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(KondominiumContext kondominiumContext) : base(kondominiumContext)
        {
        }

        public IEnumerable<Apartamento> ListarPorBloco(int idBloco)
        {
            return DbSet.Where(x => x.BlocoId == idBloco);
        }

        public IEnumerable<Apartamento> ListarPorCondominio(int idCondominio)
        {
            return DbSet.Where(x => x.Bloco.CondominioId == idCondominio);
        }

        public void Salvar(Apartamento apartamento)
        {
            if (apartamento.Id == 0)
            {
                Inserir(apartamento);
            }
            else
            {
                Atualizar(apartamento);
            }
        }
    }
}

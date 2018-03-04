using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using Kondominium.RepositoryBase.Transactions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly KondominiumContext _kondominiumContext;
        protected readonly DbSet<T> DbSet;
        private readonly IUow uow;

        public RepositoryBase(KondominiumContext kondominiumContext)
        {
            _kondominiumContext = kondominiumContext;
            DbSet = _kondominiumContext.Set<T>();
            uow = new Uow(_kondominiumContext);
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public T RecuperarPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> Listar()
        {
            return DbSet;
        }

        public void Inserir(T t)
        {
            DbSet.Add(t);
            uow.Commit();
        }

        public void Atualizar(T t)
        {
            DbSet.Update(t);
            uow.Commit();
        }

        public void Dispose()
        {
            _kondominiumContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Transactions
{
    public class Uow : IUow
    {
        private readonly KondominiumContext _context;

        public Uow(KondominiumContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
           
        }
    }
}

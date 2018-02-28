using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Transactions
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}

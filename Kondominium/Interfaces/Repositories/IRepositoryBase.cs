using System.Collections.Generic;
using System.Linq;

namespace Kondominium.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase <T>
    {
        void Insert(T t);
        void Update(T t);
        T GetById(int id);
        IQueryable<T> List();
        void Delete(int id);
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Kondominium.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase <T>
    {
        void Inserir(T t);
        void Atualizar(T t);
        T RecuperarPorId(int id);
        IQueryable<T> Listar();
        void Excluir(int id);
    }
}

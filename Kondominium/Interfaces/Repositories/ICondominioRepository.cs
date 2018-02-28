using Kondominium.Domain.Entities;

namespace Kondominium.Domain.Interfaces.Repositories
{
    public interface ICondominioRepository : IRepositoryBase<Condominio>
    {
        void Save(Condominio condominio);
    }
}

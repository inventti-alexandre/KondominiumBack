using Kondominium.Domain.Entities;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(KondominiumContext kondominiumContext) : base(kondominiumContext)
        {
        }

        public void Save(Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                Insert(usuario);
            }
            else
            {
                Update(usuario);
            }
        }
    }
}

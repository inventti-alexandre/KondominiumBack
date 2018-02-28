using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Interfaces.Commands
{
    public interface ICommandSave<T>
    {
        void Save(T t);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.Domain.Interfaces.Commands
{
    public interface ICommandList<T>
    {
        List<T> List();
    }
}

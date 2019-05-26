using System;
using System.Collections.Generic;
using System.Text;

namespace Sun.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}

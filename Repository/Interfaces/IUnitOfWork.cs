using System;

namespace Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
    }
}

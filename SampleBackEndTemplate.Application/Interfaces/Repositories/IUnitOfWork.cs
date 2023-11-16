using System;
using System.Threading;
using System.Threading.Tasks;

namespace SampleBackEndTemplate.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit(CancellationToken cancellationToken);

        Task Rollback();
    }
}
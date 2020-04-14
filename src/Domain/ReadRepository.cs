using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountsManager.Domain
{
    public interface ReadRepository<T> where T : class
    {
        Task<ICollection<T>> GetAllByAccountIdAsync(int accountId);

        Task<T> GetOneByAccountIdAndIdAsync(int accountId, int id);
    }
}

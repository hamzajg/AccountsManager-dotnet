using System;
using System.Threading.Tasks;

namespace AccountsManager.Domain
{
    public interface WriteRepository<T> where T : class
    {
        Task<bool> StoreAsync(int accountId, T obj);

        Task<bool> UpdateAsync(int accountId, T obj);

        Task<bool> DeleteAsync(T obj);
    }
}

using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    /// <summary>
    ///  Generic async repository definition.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAsyncRepository<T> where T : EntityBase<int>
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();

        // For implementing the specification pattern
        //Task<List<T>> ListAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

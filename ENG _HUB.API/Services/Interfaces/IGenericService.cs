namespace ENG__HUB.API.Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken=default);
        Task<T?> GetByIdAsync(object id, CancellationToken cancellationToken=default);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(object id, CancellationToken cancellationToken = default);
    }
}

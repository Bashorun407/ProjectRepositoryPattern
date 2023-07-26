namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        void Update(T entity);
        void DeleteRange(IEnumerable<T> entities);
    }
}
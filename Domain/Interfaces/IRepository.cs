namespace Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAll();

        Task Create(T entity);
    }
}

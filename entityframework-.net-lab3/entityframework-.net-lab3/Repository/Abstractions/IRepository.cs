namespace entityframework_.net_lab3.Repository.Abstractions
{
    public interface IRepository<T>
    {
        Task<T> CreateAsync();
        Task <bool> DeleteAsync();
        Task<bool> UpdateAsync();
        Task<List<T>> GetAllAsync();
        Task<T> GetById();

    }
}

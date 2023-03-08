using entityframework_.net_lab3.Data.Entities;
using entityframework_.net_lab3.Repository.Abstractions;

namespace entityframework_.net_lab3.Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity

    {
        public Task<T> CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}

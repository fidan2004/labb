using entityframework_.net_lab3.Data.Entities;
using entityframework_.net_lab3.Repository.Abstractions;

namespace entityframework_.net_lab3.Repository.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

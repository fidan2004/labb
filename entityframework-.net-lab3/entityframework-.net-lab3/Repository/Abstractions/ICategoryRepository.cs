using entityframework_.net_lab3.Data.Entities;

namespace entityframework_.net_lab3.Repository.Abstractions
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Add(Category category);
    }
}

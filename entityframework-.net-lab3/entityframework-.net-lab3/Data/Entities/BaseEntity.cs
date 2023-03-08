namespace entityframework_.net_lab3.Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } 
    }
}

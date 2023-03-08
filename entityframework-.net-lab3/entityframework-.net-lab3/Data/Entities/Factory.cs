namespace entityframework_.net_lab3.Data.Entities
{
    public class Factory : BaseEntity
    {
        public string Name { get; set; }
        
        //one-to-many
        public virtual ICollection<Product> Products { get; set; }

    }
}

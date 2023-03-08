namespace entityframework_.net_lab3.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int DeliveryTime { get; set; }

        //one-to-many
        public virtual ICollection<Product> Products { get; set; }
    }
}

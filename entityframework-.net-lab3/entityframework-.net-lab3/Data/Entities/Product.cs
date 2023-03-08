namespace entityframework_.net_lab3.Data.Entities
{
    public class Product : BaseEntity
    {
       
        public string Name { get; set; }
        public int Count { get; set; }

        //one-to many Factory
        public int FactoryId { get; set; }
        public virtual Factory Factory { get; set; }

        //one-to-many Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }  

        //many-to-many
        public virtual ICollection<CargoProduct> CargoProducts { get; set; }
    }
}

namespace entityframework_.net_lab3.Data.Entities
{
    public class CargoProduct : BaseEntity
    {
       
        public int ProductId { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public Product Product { get; set; }

    }
}

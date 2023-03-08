namespace entityframework_.net_lab3.Data.Entities
{
    public class Cargo:BaseEntity
    {

        public virtual ICollection<CargoProduct> CargoProducts { get; set; }

    }
}

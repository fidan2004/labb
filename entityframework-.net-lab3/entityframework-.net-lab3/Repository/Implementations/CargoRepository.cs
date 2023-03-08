using entityframework_.net_lab3.Data.Entities;
using entityframework_.net_lab3.Repository.Abstractions;

namespace entityframework_.net_lab3.Repository.Implementations
{
    public class CargoRepository:Repository<Cargo>, ICargoRepository //Repository<Cargo>bunu yazmasa
                                                                     //idim error olacaqdi cunki ICargorepository implement etmeyimi isteyir.
                                                                     //onunda implementasiyasi Repository<Cargo> burda var
    {
    }
}

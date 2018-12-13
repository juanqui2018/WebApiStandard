using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.EFContext
{
    public class ParqueoContext: DbContext
    {
        public ParqueoContext()
        //: base("name=ParqueoContext")//llamada al constructor padre
        {
            Database.SetInitializer<ParqueoContext>(new CreateDatabaseIfNotExists<ParqueoContext>());
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<InputOutputCar> InputOutputCars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<SetMoney> SetMoneys { get; set; }
    }
}

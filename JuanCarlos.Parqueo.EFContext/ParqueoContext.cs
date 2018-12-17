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
        public ParqueoContext() : base("name=ParqueoContext")
        {
            Database.SetInitializer<ParqueoContext>(new UniDBInitializer<ParqueoContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarPark>()
                        .HasOptional(s => s.SetMoney)
                        .WithRequired(ad => ad.CarPark);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<InputOutputCar> InputOutputCars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<SetMoney> SetMoneys { get; set; }

        private class UniDBInitializer<T> : CreateDatabaseIfNotExists<ParqueoContext>
        {
            protected override void Seed(ParqueoContext context)
            {
                SetMoney smOne = new SetMoney()
                {
                    CreatedOn = DateTime.Parse(DateTime.Today.ToString()),
                    Status = "active",
                    Observation = "created by default",
                    FirstHour = 5,
                    AdditionalHour = 1,
                };
                context.SetMoneys.Add(smOne);

                CarPark cpOne = new CarPark()
                {
                    CreatedOn = DateTime.Parse(DateTime.Today.ToString()),
                    Status = "active",
                    Observation = "created by default",
                    Name = "Parqueo 6 DE AGOSTO",
                    Address = "Qllo. calle 6 de Agostso Nro: 123",
                    CapacityCars = 20,
                };
                context.CarParks.Add(cpOne);

                IList<Parking> parkings = new List<Parking>();

                for (int i = 0; i < cpOne.CapacityCars; i++)
                {
                    parkings.Add(new Parking {
                        CreatedOn = DateTime.Parse(DateTime.Today.ToString()),
                        Status = "active",
                        Observation = "created by default",
                        CodeName = (i+1).ToString(),
                        Free = true
                    });
                }
                foreach (Parking student in parkings)
                    context.Parkings.Add(student);

                base.Seed(context);
            }
        }
    }
}

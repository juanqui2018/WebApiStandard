using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class InputOutputCarDao:IInputOutputCarDao
    {
        public InputOutputCarDao()
        {
        }
        public void Create(InputOutputCar inputOutputCar)
        {
            using (var context = new ParqueoContext())
            {
                context.InputOutputCars.Add(inputOutputCar);
                context.SaveChanges();
            }
        }

        public void Update(InputOutputCar inputOutputCar)
        {
            using (var context = new ParqueoContext())
            {
                var inputOutputCarUpdate = context.InputOutputCars.SingleOrDefault(x => x.Id == inputOutputCar.Id);
                if (inputOutputCarUpdate != null)
                {
                    inputOutputCarUpdate.LastUpdatedOn = inputOutputCar.LastUpdatedOn;
                    inputOutputCarUpdate.Status = inputOutputCar.Status;
                    inputOutputCarUpdate.Observation = inputOutputCar.Observation;

                    inputOutputCarUpdate.Name = inputOutputCar.Name;
                    inputOutputCarUpdate.FatherName = inputOutputCar.FatherName;
                    inputOutputCarUpdate.MotherName = inputOutputCar.MotherName;
                    inputOutputCarUpdate.Ci = inputOutputCar.Ci;
                    inputOutputCarUpdate.PhoneNumber = inputOutputCar.PhoneNumber;

                    inputOutputCarUpdate.CarPlate = inputOutputCar.CarPlate;
                    inputOutputCarUpdate.Model = inputOutputCar.Model;
                    inputOutputCarUpdate.Color = inputOutputCar.Color;
                    inputOutputCarUpdate.Brand = inputOutputCar.Brand;
                    inputOutputCarUpdate.TypeCar = inputOutputCar.TypeCar;

                    inputOutputCarUpdate.FirstHour = inputOutputCar.FirstHour;
                    inputOutputCarUpdate.AdditionalHour = inputOutputCar.AdditionalHour;
                    inputOutputCarUpdate.InHour = inputOutputCar.InHour;
                    inputOutputCarUpdate.OutHour = inputOutputCar.OutHour;
                    inputOutputCarUpdate.BigTotal = inputOutputCar.BigTotal;
                }
                context.SaveChanges();
            }
        }

        public void Delete(InputOutputCar inputOutputCar)
        {
            using (var context = new ParqueoContext())
            {
                var inputOutputCarDelete = context.InputOutputCars.SingleOrDefault(x => x.Id == inputOutputCar.Id);
                context.InputOutputCars.Remove(inputOutputCarDelete);
                context.SaveChanges();
            }
        }

        public InputOutputCar GetForId(int id)
        {
            InputOutputCar inputOutputCar;
            using (var context = new ParqueoContext())
            {
                inputOutputCar = context.InputOutputCars.SingleOrDefault(x => x.Id == id);
            }
            return inputOutputCar;
        }

        public IEnumerable<InputOutputCar> GetAll()
        {
            List<InputOutputCar> inputOutputCars;
            using (var context = new ParqueoContext())
            {
                inputOutputCars = context.InputOutputCars.Where(x => x.CreatedOn != null).ToList();
            }
            return inputOutputCars;
        }
    }
}

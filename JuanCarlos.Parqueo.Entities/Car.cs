using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Car:BaseModel
    {
        public string CarPlate { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string TypeCar  { get; set; } //en UI vagoneta, micro, moto, etc
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuanCarlos.Parqueo.WebApiStandard.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }

        public string CarPlate { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string TypeCar { get; set; } //en UI vagoneta, micro, moto, etc
        public string Observation { get; set; }
    }
}
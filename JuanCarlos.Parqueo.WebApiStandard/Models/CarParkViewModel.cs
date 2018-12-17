using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuanCarlos.Parqueo.WebApiStandard.Models
{
    public class CarParkViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public int CapacityCars { get; set; }
        public string Observation { get; set; }
    }
}
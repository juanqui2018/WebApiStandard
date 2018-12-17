using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuanCarlos.Parqueo.WebApiStandard.Models
{
    public class ParkingViewModel
    {
        public int Id { get; set; }

        public string CodeName { get; set; }
        public bool Free { get; set; }
        public string Observation { get; set; }
    }
}
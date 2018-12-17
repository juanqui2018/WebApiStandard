using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuanCarlos.Parqueo.WebApiStandard.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Ci { get; set; }
        public string PhoneNumber { get; set; }
        public string Observation { get; set; }
    }
}
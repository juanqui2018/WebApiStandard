using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuanCarlos.Parqueo.WebApiStandard.Models
{
    public class SetMoneyViewModel
    {
        public int Id { get; set; }

        public int FirstHour { get; set; }
        public int AdditionalHour { get; set; }
        public string Observation { get; set; }
    }
}
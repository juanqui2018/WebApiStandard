using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Car:BaseModel
    {
        [StringLength(64)]
        public string CarPlate { get; set; }
        [StringLength(64)]
        public string Model { get; set; }
        [StringLength(64)]
        public string Color { get; set; }
        [StringLength(64)]
        public string Brand { get; set; }
        [StringLength(64)]
        public string TypeCar  { get; set; }
    }
}

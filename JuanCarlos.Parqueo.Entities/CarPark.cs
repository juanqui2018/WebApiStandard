using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class CarPark:BaseModel
    {
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Address { get; set; }
        public int CapacityCars { get; set; } 

        public virtual ICollection<Parking> parkings { get; set; }
        public virtual ICollection<InputOutputCar> inputOutputCars { get; set; }
        public virtual ICollection<Client> clients { get; set; }

        public virtual SetMoney SetMoney { get; set; }
    }
}

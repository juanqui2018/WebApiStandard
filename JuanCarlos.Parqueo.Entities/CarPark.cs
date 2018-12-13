using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class CarPark:BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CapacityCars { get; set; } //de aqui se dibuja el mapa
        //
        public List<Parking> parkings = new List<Parking>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        [StringLength(64)]
        public string Status { get; set; }
        [StringLength(128)]
        public string Observation { get; set; }
    }
}

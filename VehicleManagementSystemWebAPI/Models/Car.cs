using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemWebAPI.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Vehicle")]
        public string VehicleType { get; set; }

        
        //public virtual Vehicle Vehicles { get; set; }

    }
}

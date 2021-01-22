using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemAPI.Models
{

    // This is Cars model inherited from Vehicles class
    public class Cars : Vehicles
    {

        
        public string Engine { get; set; }

        public int Doors { get; set; }

        public int wheels { get; set; }

        
        public string bodyType { get; set; }

        [ForeignKey("bodyType")]
        public BodyTypes BodyTypes { get; set; }

        //public virtual Vehicle Vehicles { get; set; }

    }
}

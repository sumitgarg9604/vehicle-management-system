using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemWebAPI.Models
{
    public class Vehicle
    {
        // To save types of vehicles such as car, boat, truck
        [Key]
        public string VehicleType { get; set; }

    }
}

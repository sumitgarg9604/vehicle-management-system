using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleManagementSystemMVC.Models
{
    public class Vehicle
    {
        [Key]
        public string VehicleType { get; set; }

    }
}

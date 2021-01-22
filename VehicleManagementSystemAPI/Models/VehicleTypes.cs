using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemAPI.Models
{
    public class VehicleTypes
    {
        [Key]
        public string VehicleType { get; set; }
    }
}

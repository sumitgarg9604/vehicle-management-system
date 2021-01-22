using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vehicleManagementSystemMVC.Models
{
    public class Car
    { 
    [Key]
    public int ID { get; set; }

    [ForeignKey("Vehicle")]
    [Required]
    public string VehicleType { get; set; }

    [Required]
    public string Make { get; set; }

    [Required]
    public string Model { get; set; }

    public string Engine { get; set; }

    public int Doors { get; set; }

    public int wheels { get; set; }

    public string bodyType { get; set; }

    public string adType { get; set; }

    //public virtual Vehicle Vehicles { get; set; }

}
}

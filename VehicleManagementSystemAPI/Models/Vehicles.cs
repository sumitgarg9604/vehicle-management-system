using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace VehicleManagementSystemAPI.Models
{
    public class Vehicles
    {
        // To save types of vehicles such as car, boat, truck
        //Vehicles will be super class for all the type of vehicles uploaded on this carsales
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int vehicleId { get; set; }

        [Required]
        public string make { get; set; }

        [Required]
        public string model { get; set; }

        [Required]
        public  string adType { get; set; }

        [Required]
                
        public string VehicleType { get; set; }

        [ForeignKey("VehicleType")]
        public VehicleTypes VehicleTypes { get; set; }

        [ForeignKey("adType")]
        public AdTypes AdTypes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemAPI.Models
{
    //This model stores different types of advtisement such as posted by Dealer or Private
    //Values in the main form can only be selected from this model type
    public class AdTypes
    {
        [Key]
        public string adType { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystemAPI.Models
{
    //This model stores different types of body  such as suv,sedan or hatch
    //Values in the main form can only be selected from this model type
    public class BodyTypes
    {
        [Key]
        public string bodyType { get; set; }

    }
}

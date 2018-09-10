using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Patient_Records.Models
{
    public class RobotDoctor
    {
        [Display(Name="Robot Doctor ID")]
        public int RobotDoctorId { get; set; }

        [Display(Name="Model Number")]
        public int ModelNumber { get; set; }

        [Display(Name="Robot Doctor Name")]
        public string PreferredName { get; set; }

    }
}

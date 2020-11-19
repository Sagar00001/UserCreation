using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserCreation.project.Models
{
    public class City
    {
        [Key]
        [Required]
        public string CityName { get; set; }

        public State State { get; set; }
    }
}

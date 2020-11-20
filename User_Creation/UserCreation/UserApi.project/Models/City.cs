using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserApi.project.Models
{
    public class City
    {
        [Key]
        [Required]
        public int CityID { get; set; }

        public string CityName { get; set; }

        public int StateID { get; set; }

        public State State { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserCreation.project.Models
{
    public class State
    {
        [Key]
        [Required]
        public int StateID { get; set; }

        public string StateName { get; set; }

        public ICollection<City> City { get; set; }
    }
}

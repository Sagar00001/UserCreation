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
        public string StateName { get; set; }
        public ICollection<City> City { get; set; }
    }
}

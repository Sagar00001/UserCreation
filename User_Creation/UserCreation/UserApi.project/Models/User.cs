using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.project.Models
{
    public class User
    {
        [Key]  
        public int ID { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        public string State { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public string Pincode { get; set; }
    }
}

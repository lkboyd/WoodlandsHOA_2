using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WoodlandsHOA_2.Models
{
    public class ContactModels
    {
        [Required(ErrorMessage = "Required Field")]
        public string FirstName { get; set;  }
        [Required(ErrorMessage = "Required Field")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Comment { get; set; }
       
    }
}
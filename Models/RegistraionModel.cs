using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddValidation.Models
{
    public class RegistraionModel
    {
        [Required(ErrorMessage = "Enter a name.")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Your name can only contain letters.")]
        [StringLength(25, ErrorMessage = "Your name can not exceed 25 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your address.")]
        [StringLength(30, ErrorMessage = "Entered address must not exceed 30 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Phone number is 10 numbers without dashes.")]
        public Int64 PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter age.")]
        [Range(18, 120, ErrorMessage = "Age must be between 18 and 120.")]
        public int Age { get; set; }
    }
}

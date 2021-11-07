using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOTSearchWebsite
{
    public class RegistrationNumberModel
    {
        // For the validation to work when searching for details I needed to create a separate class to be able to validate if the field is empty or has too many characters.
        // I could of used the shared library I created to achieve this but validator seems to look for the rest of fields apart from registration number so hence this class.
        [Required(ErrorMessage = "Please enter your registration number")]
        [StringLength(7, ErrorMessage = "Registration number is too long")]
        [MinLength(5, ErrorMessage = "Registration number must be at least 5 characters long")]
        public string RegistrationNumber { get; set; }
    }
}

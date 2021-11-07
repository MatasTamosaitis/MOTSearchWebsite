using System;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary
{
    public class MOTDetailModel
    {
        [Required(ErrorMessage = "Please enter your registration number")]
        [StringLength(7, ErrorMessage = "Registration number is too long")]
        [MinLength(5, ErrorMessage = "Registration number must be at least 5 characters long")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Please enter the make of your vehicle")]
        [StringLength(15, ErrorMessage = "Make of vehicle is too long")]
        [MinLength(4, ErrorMessage = "Make of vehicle must be at least 4 characters long")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the model of your vehicle")]
        [StringLength(20, ErrorMessage = "Model of vehicle is too long")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter the colour of your vehicle")]
        [StringLength(10, ErrorMessage = "Colour of vehicle is too long")]
        [MinLength(3, ErrorMessage = "Colour of vehicle must be at least 3 characters long")]
        public string Colour { get; set; }

        public string ExpiryDate { get; set; }
        public string Milage { get; set; }
    }
}

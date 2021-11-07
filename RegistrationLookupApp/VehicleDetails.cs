using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationLookupApp
{
    [Table("VehicleDetails")]
    public class VehicleDetails
    {     
        // These fields will act as the columns for the table in the database.
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Colour { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
        [Required]
        public string Milage { get; set; }
    }
}

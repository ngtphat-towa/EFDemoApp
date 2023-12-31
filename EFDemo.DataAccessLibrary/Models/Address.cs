using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.DataAccessLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string StreetAddress { get; set; }

        [Required]
        [StringLength(100)]
        public required string City { get; set; }

        [StringLength(50)]
        public required string State { get; set; }

        [Required]
        [StringLength(10)]
        //[RegularExpression(@"^\d{5}(-\d{4})?$")] // Example for US ZIP code format
        [Column(TypeName="varchar(10)")]
        public required string ZipCode { get; set; }
    }
}

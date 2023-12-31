using System.ComponentModel.DataAnnotations;

namespace EFDemo.DataAccessLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string EmailAddress { get; set; }
    }
}
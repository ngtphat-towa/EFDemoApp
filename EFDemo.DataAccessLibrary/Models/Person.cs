using System.ComponentModel.DataAnnotations;

namespace EFDemo.DataAccessLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public  string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> Emails { get; set; } = new List<Email>();
    }
}

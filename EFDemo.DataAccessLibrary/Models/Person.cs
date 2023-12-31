﻿namespace EFDemo.DataAccessLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> Emails { get; set; } = new List<Email>();
    }
}

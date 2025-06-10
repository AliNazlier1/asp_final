using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Student
    {   
        [Key]
        public int StudentId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        [StringLength(200)]
        public string Address { get; set; }
    }
}
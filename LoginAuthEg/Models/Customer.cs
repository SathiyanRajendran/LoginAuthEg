using System;
using System.ComponentModel.DataAnnotations;

namespace LoginAuthEgown.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
       
        [Required(ErrorMessage ="*")]
        public string CustomerName { get; set; }
       
        [Range(5000,80000,ErrorMessage ="Please enter arange between 5000 and 80000")]

        public float Salary { get; set; }

        [Display(Name = "Date of Joining")]
        public DateTime doj { get; set; }

        [Required(ErrorMessage ="Please enter an Email ID")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Please enter a valid Email ID")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        [NotMapped]
        public string CPassword { get; set; }
    }

    internal class NotMappedAttribute : Attribute
    {
    }
}

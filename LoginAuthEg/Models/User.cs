
using System.ComponentModel.DataAnnotations;

namespace LoginAuthEg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string UserName { get; set; }  
        public string Password { get; set; }    

    }
}

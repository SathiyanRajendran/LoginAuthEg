using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginAuthEg.Models
{
    public class Supplier
    {
        [Key]
        public int Sid { get; set; }
        public string SName { get; set; }
        public string location { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    

    }
}

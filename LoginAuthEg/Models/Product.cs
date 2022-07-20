using System.ComponentModel.DataAnnotations;

namespace LoginAuthEg.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }
        public string Pimage { get; set; }

        public virtual Supplier SidNavigation { get; set; }
    }
}

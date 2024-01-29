using System.ComponentModel.DataAnnotations;

namespace razor_asp.Models
{
    public class Product
    {
        [Key]
        public Guid Id {get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }  
    }
}

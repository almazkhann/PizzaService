using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class MPizza
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }
        [Range(0.01, 9999.9)]
        public decimal Price { get; set; }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}

using Dapper.Contrib.Extensions;

namespace Lab_01_CoffeeShop.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}

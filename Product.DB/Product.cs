using System;
using System.ComponentModel.DataAnnotations;

namespace Product.DB
{
    /// <summary>
    /// This is a product entity
    /// </summary>
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string ImageId { get; set; }
    }
}

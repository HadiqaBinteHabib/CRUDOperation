using System.ComponentModel.DataAnnotations;

namespace CRUDOperation.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}

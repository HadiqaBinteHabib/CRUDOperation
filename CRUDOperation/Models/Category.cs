using System.ComponentModel.DataAnnotations;

namespace CRUDOperation.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }


        public virtual List<Product> Products { get; set; }

    }
}

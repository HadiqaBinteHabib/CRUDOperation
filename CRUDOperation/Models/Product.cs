using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDOperation.Models
{
    public class Product
    {
        [Key]
        public int ProductId{ get; set; }


        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set;}
        public int CategoryId { get; set; }//Fk


        //Navigation

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


    }
}

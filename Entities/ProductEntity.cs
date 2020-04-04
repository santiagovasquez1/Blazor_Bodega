using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        [Required]
        public int ProductTotalQuantity { get; set; }
        
        public string CategoryId { get; set; }
        //Relacion Elementos
        public CategoryEntity Category { get; set; }
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
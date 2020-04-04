using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class warehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseDress { get; set; }
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity: BaseEntity 
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int TotalQuantity { get; set; }
        
        public CategoryEntity CategoryEntity { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}

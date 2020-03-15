using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity: BaseEntity 
    {
        [Required]
        public DateTime LasUpdate { get; set; }

        public int PartialQuantity { get; set; }

        public ProductEntity Product { get; set; }

        public WhereHouseEntity WhereHouse { get; set; }

        public ICollection<InputOutputEntity> InputOutputs { get; set; }

    }
}

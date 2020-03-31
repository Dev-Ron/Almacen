using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity: BaseEntity 
    {
        [Required(ErrorMessage = "Requerido")]
        public DateTime LasUpdate { get; set; }

        public int PartialQuantity { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public ProductEntity Product { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public WhereHouseEntity WhereHouse { get; set; }

        public ICollection<InputOutputEntity> InputOutputs { get; set; }

    }
}

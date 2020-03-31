using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class InputOutputEntity: BaseEntity
    {
        [Required(ErrorMessage = "Requerido")]
        public DateTime InOutDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Por favor ingrese un numero valido")]
        public int Quantity { get; set; }

        public bool IsInput { get; set; }

        public StorageEntity Storage { get; set; }

        [NotMapped]
        public WhereHouseEntity WhereHouse { get; set; }

        [NotMapped]
        public ProductEntity Product { get; set; }
    }
}

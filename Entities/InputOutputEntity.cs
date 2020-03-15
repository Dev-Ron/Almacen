using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEntity: BaseEntity
    {
        [Required]
        public DateTime InOutDate { get; set; }

        public int Quantity { get; set; }

        public bool IsInput { get; set; }

        public StorageEntity Storage { get; set; }

    }
}

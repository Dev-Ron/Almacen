using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WhereHouseEntity : BaseEntity 
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }

    }
}

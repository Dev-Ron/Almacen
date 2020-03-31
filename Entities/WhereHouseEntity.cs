using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WhereHouseEntity : BaseEntity 
    {
        [Required(ErrorMessage = "Requerido")]
        [StringLength(100, ErrorMessage = "Es una cadena muy larga")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [StringLength(100, ErrorMessage = "Es una cadena muy larga")]
        public string Direccion { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }

    }
}

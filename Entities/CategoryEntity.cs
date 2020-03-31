using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CategoryEntity : BaseEntity
    {
        [Required(ErrorMessage = "Requerido")]
        [StringLength(100, ErrorMessage = "Es una cadena muy larga")]
        public string Name { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}

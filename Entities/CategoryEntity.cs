using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CategoryEntity : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}

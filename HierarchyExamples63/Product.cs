namespace HierarchyExamples63
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hierarchy.Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public int? ProductCategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
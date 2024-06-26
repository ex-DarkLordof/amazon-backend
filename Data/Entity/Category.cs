﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazon_backend.Data.Entity
{
    public class Category
    {
        [Key]
        public uint Id { get; set; }
        public uint? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Description { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Image { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public bool IsVisible { get; set; }
        List<CategoryPropertyKey>? CategoryPropertyKeys { get; set; }
    }
}

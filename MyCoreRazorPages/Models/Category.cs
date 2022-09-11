﻿using System.ComponentModel.DataAnnotations;
namespace MyCoreRazorPages.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        public int DisplayOrder { get; set; }
    }
}
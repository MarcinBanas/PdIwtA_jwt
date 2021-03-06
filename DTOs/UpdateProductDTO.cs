using System;
using System.ComponentModel.DataAnnotations;

namespace Lab.DTOs
{
    public class UpdateProductDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}

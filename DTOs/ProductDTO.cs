using Lab.Domain;
using System;

namespace Lab.DTOs
{
    public class ProductDTO
    {
        public ProductDTO(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            IsAvailable = product.IsAvailable;
        }
        public Guid Id { get; init; }
        public string Name { get; init; }
        public bool IsAvailable { get; init; }
    }
}

using System;

namespace Lab.Domain
{
    public interface IProductsRepository
    {
        bool Exists(Guid id);
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Guid id);
   }
}



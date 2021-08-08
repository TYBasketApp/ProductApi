using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);
        List<Product> GetProductsByIds(List<int> productIds);
    }
}
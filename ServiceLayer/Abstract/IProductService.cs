using System.Collections.Generic;
using System.Diagnostics;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ServiceLayer.Concrete;

namespace ServiceLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);
        List<Product> GetProductsByIds(List<int> productIds);
    }
}
using System.Collections.Generic;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using ServiceLayer.Abstract;

namespace ServiceLayer.Concrete
{
    public class ProductService : IProductService
    {
        private IProductDal _productDal;
        
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetProductsByIds(List<int> productIds)
        {
            return _productDal.GetProductsByIds(productIds);
        }
    }
}
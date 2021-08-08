using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.EFContext;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                return context.Products.FirstOrDefault(x => x.Id == id);
            }
        }

        public Product Add(Product product)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

                return product;
            }
        }

        public Product Update(Product product)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                context.Products.Update(product);
                context.SaveChanges();

                return product;
            }
        }

        public void Delete(Product product)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public List<Product> GetProductsByIds(List<int> productIds)
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                var products = context.Products.Where(x => productIds.Contains(x.Id)).ToList();

                return products;
            }
        }
    }
}
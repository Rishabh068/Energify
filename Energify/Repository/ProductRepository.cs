using Energify.Data;
using Energify.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Repository
{
    public class ProductRepository
    {
        public EnergifyDbContext _dbcontext;

        public IEnumerable<object> ProductList { get; private set; }

        public ProductRepository(EnergifyDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }
        public IEnumerable<ProductEntity> GetProducts()
        {
            return _dbcontext.ProductsList;
        }
        public ProductEntity Addproduct(string name, int price, int quant, string status, string measurement, string desc, string cat, string img)
        {
            var add = new ProductEntity() { Name = name, Price = price, Quantity = quant, Status = status, Measurement = measurement, Description = desc, CategoryName = cat, Image = img };
            _dbcontext.ProductsList.Add(add);
            _dbcontext.SaveChanges();
            return add;
        }
        public ProductEntity RemoveProduct(int id)
        {
            _dbcontext.ProductsList.Remove(_dbcontext.ProductsList.First(s => s.Id == id));
            _dbcontext.SaveChanges();
            return new ProductEntity() { Name="deleted" };

        }

    }
}

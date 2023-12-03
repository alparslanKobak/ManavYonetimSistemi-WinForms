using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class ProductCrud : ICrud<Product>
    {
        DataContext _db = new DataContext();

        public bool Add(Product entity)
        {
            entity.IsStatus = true;
            _db.Products.Add(entity);
            if (_db.SaveChanges() > 1)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Product product = _db.Products.FirstOrDefault(x=> x.Id ==id);
            product.IsDelete = true;
      
            if (_db.SaveChanges() > 1)
            {
                return true;
            }
            return false;

        }

        public List<Product> GetAll()
        {
            
            return _db.Products.AsNoTracking().Where(x=> !x.IsDelete).ToList();

        }

        public Product GetById(int id)
        {
           
            return _db.Products.AsNoTracking().FirstOrDefault(x=> x.Id == id && !x.IsDelete);
        }

        public bool Update(Product entity, int id)
        {
           
            Product product = _db.Products.FirstOrDefault(x=> x.Id == id);
            product.Name = entity.Name;
            product.Price = entity.Price;
            product.Stock = entity.Stock;
            product.CategoryId = entity.CategoryId;
            product.Description = entity.Description;
            product.Image = entity.Image;
            product.IsDelete = entity.IsDelete;
            //product.SellProductList = entity.SellProductList;
            //product.BuyProductList = entity.BuyProductList;
            product.IsStatus = entity.IsStatus;
            
            if (_db.SaveChanges() > 1)
            {
                return true;
            }
            return false;

        }
    }
}

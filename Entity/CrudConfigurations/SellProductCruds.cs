using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class SellProductCruds : ICrud<SellProduct>
    {
        DataContext _db = new DataContext();

        public bool Add(SellProduct entity)
        {

            _db.SellProducts.Add(entity);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }


        public bool Delete(int id)
        {
            SellProduct entity = _db.SellProducts.FirstOrDefault(x => x.Id == id);
            entity.IsDelete = true;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }


        public List<SellProduct> GetAll()
        {
            return _db.SellProducts.ToList();
        }

        public SellProduct GetById(int id)
        {
            return _db.SellProducts.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(SellProduct entity, int id)
        {
            SellProduct sellProduct = _db.SellProducts.FirstOrDefault(x => x.Id == id);
  
            sellProduct.ProductId = entity.ProductId;
         
            sellProduct.OrderId = entity.OrderId;
            sellProduct.Price = entity.Price;
            sellProduct.Quantity = entity.Quantity;
            sellProduct.IsDelete = entity.IsDelete;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
    
}

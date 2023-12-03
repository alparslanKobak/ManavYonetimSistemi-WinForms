using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class BuyProductCruds : ICrud<BuyProduct>
    {
        DataContext _db = new DataContext();

        public bool Add(BuyProduct entity)
        {

            _db.BuyProducts.Add(entity);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }


        public bool Delete(int id)
        {
            BuyProduct entity = _db.BuyProducts.FirstOrDefault(x => x.Id == id);
            entity.IsDelete = true;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }


        public List<BuyProduct> GetAll()
        {
            return _db.BuyProducts.ToList();
        }

        public BuyProduct GetById(int id)
        {
            return _db.BuyProducts.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(BuyProduct entity, int id)
        {
            BuyProduct buyProduct = _db.BuyProducts.FirstOrDefault(x => x.Id == id);
            buyProduct.UserId = entity.UserId;
            buyProduct.ProductId = entity.ProductId;
            buyProduct.Quantity = entity.Quantity;
            buyProduct.IsDelete = entity.IsDelete;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

      
    }
}

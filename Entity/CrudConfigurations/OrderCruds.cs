using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class OrderCruds : ICrud<Order>
    {
        DataContext _db = new DataContext();

        public bool Add(Order entity)
        {

            _db.Orders.Add(entity);

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {

            Order order = _db.Orders.FirstOrDefault(x => x.Id == id);
            order.IsDelete = true;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Order> GetAll()
        {

            return _db.Orders.AsNoTracking().Where(x => !x.IsDelete).ToList();

        }

        public Order GetById(int id)
        {
            return _db.Orders.Where(x => !x.IsDelete).FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Order entity, int id)
        {
            Order order = _db.Orders.FirstOrDefault(x => x.Id == id);
            order.SellProductList = entity.SellProductList;
            order.UserId = entity.UserId;

            order.IsDelete = entity.IsDelete;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }

            return false;

        }
    }

}

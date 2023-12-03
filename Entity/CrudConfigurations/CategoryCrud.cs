using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class CategoryCrud : ICrud<Category>
    {
        DataContext _db = new DataContext();
        public bool Add(Category entity)
        {
            entity.IsStatus = true;
            _db.Categories.Add(entity);

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Category category = _db.Categories.FirstOrDefault(x => x.Id == id);
            category.IsDelete = true;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return _db.Categories.AsNoTracking().Where(x => !x.IsDelete).ToList();
        }

        public Category GetById(int id)
        {
            return _db.Categories.Where(x => !x.IsDelete).FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Category entity, int id)
        {
            Category category = _db.Categories.FirstOrDefault(x => x.Id == id);
            category.Name = entity.Name;
            category.Description = entity.Description;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}

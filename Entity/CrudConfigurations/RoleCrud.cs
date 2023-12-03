using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class RoleCrud : ICrud<Role>
    {
        DataContext _db = new DataContext();

        public bool Add(Role entity)
        {
            _db.Roles.Add(entity);

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Role role = _db.Roles.FirstOrDefault(x => x.Id == id);
            role.IsDelete = true;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Role> GetAll()
        {
            return _db.Roles.AsNoTracking().Where(x => !x.IsDelete).ToList();
        }

        public Role GetById(int id)
        {
            return _db.Roles.Where(x => !x.IsDelete).FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Role entity, int id)
        {
            Role role = _db.Roles.FirstOrDefault(x => x.Id == id);
            role.Name = entity.Name;
            role.Description = entity.Description;

            if (_db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }


       
    }
}

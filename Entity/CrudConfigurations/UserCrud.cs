using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.CrudConfigurations
{
    public class UserCrud : ICrud<User>
    {
        DataContext _db = new DataContext();
        public bool Add(User entity)
        {
            entity.IsStatus = true;
            _db.Users.Add(entity);

            if (_db.SaveChanges() >0)
            {
                return true;
            }
            return  false;
        }

        public bool Delete(int id)
        {
            User user = _db.Users.FirstOrDefault(x=> x.Id==id);
            user.IsDelete = true;
            
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return _db.Users.AsNoTracking().Where(x=> !x.IsDelete).ToList();
        }

        public User GetById(int id)
        {
            return _db.Users.Where(x=> !x.IsDelete).FirstOrDefault(x=> x.Id == id);
        }

        public bool Update(User entity, int id)
        {
            User user = _db.Users.FirstOrDefault(x=> x.Id ==id);
            user.Name = entity.Name;
            user.Surname = entity.Surname;
            user.Email = entity.Email;
            user.Password = entity.Password;
            user.RoleId = entity.RoleId;
            user.Image = entity.Image;


            if (_db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}


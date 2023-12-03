
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.CrudConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Data
{
    public class DbSeeder
    {
        DataContext _context = new DataContext();

        RoleCrud _roleCrud = new RoleCrud();

        UserCrud _userCrud = new UserCrud();

        ProductCrud _productCrud = new ProductCrud();

        CategoryCrud _categoryCrud = new CategoryCrud();





        public void Seed()
        {

            SeedRoles();
            SeedUsers();
            SeedCategories();
            SeedProducts();

        }

        public void SeedRoles()
        {
            if (_context.Roles.Count() == 0)
            {
                _roleCrud.Add(new Role() { Name = "Admin" });
                _roleCrud.Add(new Role() { Name = "Customer" });

            }
        }



        public void SeedUsers()
        {
            if (_context.Users.Count() == 0)
            {
                _userCrud.Add(new User() { Name = "Alparslan", Surname = "KOBAK", Email = "admin@bursamanav.com", Password = "123456789", RoleId = 1, Image = "https://media.licdn.com/dms/image/C4E03AQEpHtI3Z6YcRA/profile-displayphoto-shrink_800_800/0/1598915463052?e=1707350400&v=beta&t=1lnQ5JaWktSLGl4A6Ab3NJHzcHpjKU7v04YXJrrE6ps", IsStatus = true });
                _userCrud.Add(new User() { Name = "Adem", Surname = "Karagülle", Email = "ademkaragülle@gmail.com", Password = "123456789", RoleId = 2, Image = "https://media.licdn.com/dms/image/D4D35AQFyAhq0WUmrWQ/profile-framedphoto-shrink_100_100/0/1680617450945?e=1702227600&v=beta&t=1mKiHYVaeeq-V-oqJdn5WgbhJTXBfLAjpX06_Izy0Dk", IsStatus = true });
                _userCrud.Add(new User() { Name = "Mehmet", Surname = "Kirisoglu", Email = "mehmetkirisoglu@roblox.com", Password = "123456789", RoleId = 2, Image = "https://media.licdn.com/dms/image/D4D03AQFApnieKJ7qbQ/profile-displayphoto-shrink_100_100/0/1692785480978?e=1707350400&v=beta&t=TuWZGRFILZQasTuNQDMauL-2PYSgh5CUDAWfqgiwVZM", IsStatus = true });
            }
        }

        public void SeedCategories()
        {
            if (_context.Categories.Count() == 0)
            {
                _categoryCrud.Add(new Category() { Name = "Meyve", Description = "Meyve", IsStatus = true });
                _categoryCrud.Add(new Category() { Name = "Sebze", Description = "Sebze", IsStatus = true });
            }
        }


        public void SeedProducts()
        {

            if (_context.Products.Count() == 0)
            {
                _productCrud.Add(new Product() { Name = "Elma", Price = 5, Stock = 100, CategoryId = 1, Description = "Amasya Elması", Image = "https://cdn.yemek.com/uploads/2015/10/elma-zencefil-suyu-aralik-2020.jpg" });
                _productCrud.Add(new Product() { Name = "Armut", Price = 6, Stock = 100, CategoryId = 1, Description = "Diyarbakır Armutu", Image = "https://ideacdn.net/idea/ha/92/myassets/products/573/armut.png?revision=1697143329" });
                _productCrud.Add(new Product() { Name = "Salatalık", Price = 7, Stock = 100, CategoryId = 2, Description = "Muz", Image = "https://im.haberturk.com/2022/04/18/3411925_5fbabba15506847be59784fc0232228b.jpg" });
                _productCrud.Add(new Product() { Name = "Domates", Price = 8, Stock = 100, CategoryId = 2, Description = "Domates", Image = "https://cdn1.ntv.com.tr/gorsel/RCOrfta2hUGI2SBC_i71pA.jpg?width=1200&height=675&mode=crop&scale=both&v=1674050490436&meta=rectangle" });
            }
        }
    }
}

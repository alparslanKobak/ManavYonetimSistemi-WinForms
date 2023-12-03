using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.CrudConfigurations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AdminPanelForm : Form
    {
        UserCrud _userCrud = new UserCrud();

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            adminControlPanelLogoPictureBoxSag.ImageLocation = "https://www.betadizayn.com.tr/wp-content/uploads/2019/06/2_ufak.jpg";
            adminControlPanelLogoPictureBoxSag.SizeMode = PictureBoxSizeMode.StretchImage;
            adminControlPanelLogoPictureBoxSol.ImageLocation = "https://www.betadizayn.com.tr/wp-content/uploads/2019/06/2_ufak.jpg";
            adminControlPanelLogoPictureBoxSol.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.ImageLocation = "https://pbs.twimg.com/profile_images/578851468561801216/V-CXHViK_400x400.jpeg";
            addNewProductPictureBox.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT91hxrdBFU1VFR3GvVI7gFQAWOJT8ghh-64Q&usqp=CAU";
            addNewProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            List<User> users = _userCrud.GetAll();
            User user = users.FirstOrDefault(u => u.Id == LoginForm._id);

            adminProfilePictureBox.ImageLocation = user.Image;
            adminProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            adminNameLabel.Text = user.Name;
            adminSurnameLabel.Text = user.Surname;
        }

        private void userEditButton_Click(object sender, EventArgs e)
        {
            UserProfileEditForm userProfileEditForm = new UserProfileEditForm();
            userProfileEditForm.Show();
        }

        private void allProductsButton_Click(object sender, EventArgs e)
        {
            AllProductsForm allProductsForm = new AllProductsForm();
            allProductsForm.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }
    }
}

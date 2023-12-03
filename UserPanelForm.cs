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
    public partial class UserPanelForm : Form
    {
        UserCrud userCrud = new UserCrud();

        public UserPanelForm()
        {
            InitializeComponent();
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {
            User user = userCrud.GetById(LoginForm._id);
            userNameLabel.Text = user.Name;
            userSurnameLabel.Text = user.Surname;
            userProfilePictureBox.ImageLocation = user.Image;
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newOrderPictureBox.ImageLocation = "https://hips.hearstapps.com/hmg-prod/images/unrecognizable-woman-shops-for-produce-in-royalty-free-image-871227828-1533830561.jpg?crop=0.668xw:1.00xh;0.0176xw,0&resize=1200:*";
            

            newOrderPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            userOrdersPictureBox.ImageLocation = "https://static.vecteezy.com/system/resources/previews/015/377/086/original/girl-checks-purchase-bill-after-supermarket-shopping-surprised-by-high-prices-woman-looks-disappointed-at-grocery-store-receipt-inflation-limited-budget-contour-line-colorful-illustration-vector.jpg";
            userOrdersPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void userEditButton_Click(object sender, EventArgs e)
        {
            UserProfileEditForm userProfileEditForm = new UserProfileEditForm();
            userProfileEditForm.Show();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.Show();
        }
    }
}

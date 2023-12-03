using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.CrudConfigurations;
using MarketYönetimSistemi.FileHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class UserProfileEditForm : Form
    {
        Functions _func = new Functions();
        UserCrud _userCrud = new UserCrud();

        public UserProfileEditForm()
        {
            InitializeComponent();
        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            _func.UploadPictureBoxImage(updateProfilePictureBox);
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            User userMain = _userCrud.GetById(LoginForm._id);

            User user = new User()
            {
                Email = emailTextBox.Text,
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Password = passwordTextBox.Text,
                RoleId = userMain.RoleId,

            };
            string userImage = "";
            string imagePath = @"C:\Users\alpar\OneDrive\Masaüstü\Öylesine\kaydedilecek\";

            if (!string.IsNullOrWhiteSpace(updateProfilePictureBox.ImageLocation))
            {
                string imageName = Guid.NewGuid().ToString() + ".jpeg";
                updateProfilePictureBox.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                userImage = imagePath + imageName;
            }
            else
            {
                userImage = "https://static.thenounproject.com/png/642902-200.png";
            }
            user.Image = userImage;
            if (_userCrud.Update(user, LoginForm._id))
            {
                MessageBox.Show("Profil Güncelleme Başarılı","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Profil Güncelleme Başarısız", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Clear();
                nameTextBox.Clear();
                surnameTextBox.Clear();
                passwordTextBox.Clear();
                updateProfilePictureBox.Image = null;

            }


        }

        private void UserProfileEditForm_Load(object sender, EventArgs e)
        {
            User userMain = _userCrud.GetById(LoginForm._id);

            emailTextBox.Text = userMain.Email;
            nameTextBox.Text = userMain.Name;
            surnameTextBox.Text = userMain.Surname;
            passwordTextBox.Text = userMain.Password;
            updateProfilePictureBox.ImageLocation = userMain.Image;
            updateProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    }
}

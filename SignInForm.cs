using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.CrudConfigurations;
using MarketYönetimSistemi.FileHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class SignInForm : Form
    {
        Functions _func = new Functions();
        UserCrud _userCrud = new UserCrud();

        public SignInForm()
        {
            InitializeComponent();
        }



        private void signInButton_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                RoleId = 2


            };

            string userImage = "";
            string imagePath = @"C:\Users\alpar\OneDrive\Masaüstü\Öylesine\";
            if (!string.IsNullOrWhiteSpace(signInPictureBox.ImageLocation))
            {
                string imageName = Guid.NewGuid().ToString() + ".jpeg";
                signInPictureBox.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                userImage = imagePath + imageName;
            }
            else
            {
                userImage = "https://static.thenounproject.com/png/642902-200.png";
            }

            user.Image = userImage;

            List<User> users = _userCrud.GetAll();
            User userControl = users.FirstOrDefault(u => u.Email == user.Email);

            if (userControl != null)
            {
                MessageBox.Show("Bu email adresi ile daha önce kayıt olunmuş!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Clear();
                passwordTextBox.Clear();
                nameTextBox.Clear();
                surnameTextBox.Clear();

                signInPictureBox.Image = null;
                return;
            }
            else
            {
                if (_userCrud.Add(user))
                {
                    MessageBox.Show("Üye kaydı başarı ile oluşturuldu", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Üye kaydı oluşturulamadı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    emailTextBox.Clear();
                    passwordTextBox.Clear();
                    nameTextBox.Clear();
                    surnameTextBox.Clear();

                    signInPictureBox.Image = null;
                }
            }

           
        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            _func.UploadPictureBoxImage(signInPictureBox);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

using MarketYönetimSistemi.Data;
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
    public partial class LoginForm : Form
    {
        DbSeeder _dbSeed = new DbSeeder();

        UserCrud _userCrud = new UserCrud();

        public static int _id = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbSeed.Seed(); // Bazı ürünlerin database üzerinde gözükebilmesi için...
            loginFormPictureBox.ImageLocation = "https://www.betadizayn.com.tr/wp-content/uploads/2019/06/2_ufak.jpg";
            loginFormPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            List<User> users = _userCrud.GetAll();

            User user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            else
            {
                _id = user.Id;
                MessageBox.Show("Giriş başarılı : " + user.Name+" "+ user.Surname);
                if (user.RoleId == 1)
                {
                    AdminPanelForm adminPanelForm = new AdminPanelForm();
                    adminPanelForm.Show();
                }
                //else
                //{
                //    UserPanelForm userPanelForm = new UserPanelForm();
                //    userPanelForm.Show();
                //}
            }


            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }
    }
}

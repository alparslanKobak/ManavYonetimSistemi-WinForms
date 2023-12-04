using MarketYönetimSistemi.Entity.CrudConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.FileHelper
{
    public class Functions
    {
        ProductCrud _productCrud = new ProductCrud();

        CategoryCrud _categoryCrud = new CategoryCrud();

        public void UploadPictureBoxImage(PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.Filter = "Files *.jpg; *.png; *.jpeg;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                string name = openFileDialog.FileName;

                string[] fileName = name.Split('\\');
                //AddRoleMsgLabel.Visible = true;
                //AddRoleMsgLabel.Text = fileName[fileName.Length - 1];
            }
        }

        public void GetAllProductsToDgv(DataGridView dgv)
        {
            dgv.DataSource = _productCrud.GetAll();
        }

        public void GetCategoryListToComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = _categoryCrud.GetAll();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        
    }
}

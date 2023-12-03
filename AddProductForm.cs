using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.CrudConfigurations;
using MarketYönetimSistemi.FileHelper;
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
    public partial class AddProductForm : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        Functions _func = new Functions();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            _func.UploadPictureBoxImage(addProductPictureBox);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Price = (double)addProductPriceValueNumericUpDown.Value,
                Stock = (int)addProductStockValueNumericUpDown.Value,
                CategoryId = (int)addProductCategoryChoosingComboBox.SelectedValue,
                Description = addProductDescriptionTextBox.Text,
                Name = addProductNameTextBox.Text,
            };

            string productImage = "";

            if (addProductPictureBox.ImageLocation == null)
            {
                productImage = "https://ichef.bbci.co.uk/news/640/cpsprodpb/753B/production/_94811003_aad20e44-3210-449d-9895-a36aa3b5bea4.jpg";
            }
            else
            {
               
                string imagePath = @"C:\Users\alpar\OneDrive\Masaüstü\Öylesine\kaydedilecek\";

                string imageName = Guid.NewGuid().ToString() + ".jpeg";

                productImage = imagePath + imageName;

                addProductPictureBox.Image.Save(productImage);

               
            }
            product.Image = productImage;

            if ((int)addProductStockValueNumericUpDown.Value > 0 && (double)addProductPriceValueNumericUpDown.Value > 0)
            {
                _productCrud.Add(product);

                MessageBox.Show("Ürün Eklendi", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AllProductsForm allProductsForm = new AllProductsForm();
                allProductsForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Ürün Eklenemedi. Stok miktarı ve fiyat 0'dan küçük olamaz! ", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            _func.GetCategoryListToComboBox(addProductCategoryChoosingComboBox);
        }
    }
}

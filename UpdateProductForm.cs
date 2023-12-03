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
    public partial class UpdateProductForm : Form
    {
        ProductCrud _productCrud = new ProductCrud();
        Functions _func = new Functions();
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            Product product = _productCrud.GetById(AllProductsForm._id);

            product.Name = updateProductNameTextBox.Text;
            product.Price = (double)updatePriceValueNumericUpDown.Value;
            product.Stock = (int)updateStockValueNumericUpDown.Value;
            product.CategoryId = (int)updateProductCategoryComboBox.SelectedValue;
            product.Description = updateProductDescriptionTextBox.Text;
            product.Image = updateProductPictureBox.ImageLocation;

            if ((int)updateStockValueNumericUpDown.Value > 0 && (double)updatePriceValueNumericUpDown.Value > 0)
            {
                _productCrud.Update(product, AllProductsForm._id);

                MessageBox.Show("Ürün Güncellendi", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AllProductsForm allProductsForm = new AllProductsForm();
                allProductsForm.Show();

                this.Close();


            }
            else
            {
                MessageBox.Show("Ürün Güncellenemedi. Stok miktarı ve fiyat 0'dan küçük olamaz! ", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {

            _func.GetCategoryListToComboBox(updateProductCategoryComboBox);

            Product product = _productCrud.GetById(AllProductsForm._id);

            updateProductNameTextBox.Text = product.Name;
            updatePriceValueNumericUpDown.Value = (decimal)product.Price;
            updateStockValueNumericUpDown.Value = product.Stock;
            updateProductCategoryComboBox.SelectedValue = product.CategoryId;
            updateProductDescriptionTextBox.Text = product.Description;
            updateProductPictureBox.ImageLocation = product.Image;
            updateProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            _func.UploadPictureBoxImage(updateProductPictureBox);
        }
    }
}

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
    public partial class AllProductsForm : Form
    {
        Functions _func = new Functions();

        ProductCrud _productCrud = new ProductCrud();

        public static int _id;

        public AllProductsForm()
        {
            InitializeComponent();
        }

        private void AllProductsForm_Load(object sender, EventArgs e)
        {
            _func.GetAllProductsToDgv(productsDataGridView);
            editProductPictureBox.ImageLocation = "https://productimages.hepsiburada.net/s/55/375-375/11210049519666.jpg";
            editProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteProductPictureBox.ImageLocation = "https://i1.imgiz.com/rshots/8100/tutitu-cop-kamyonu-cocuk-oyunlari_8100850-26250_640x360.jpg";
            deleteProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            choosenProductLabel.Visible = false;





        }

        private void productsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(productsDataGridView.CurrentRow.Cells["Id"].Value);
            Product product = _productCrud.GetById(_id);

            editProductPictureBox.ImageLocation = product.Image;
            editProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            deleteProductPictureBox.ImageLocation = product.Image;
            deleteProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            choosenProductLabel.Visible = true;
            choosenProductLabel.Text = "Seçtiğiniz Ürün : " + product.Name;

        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ürünü silmek istediğinize Emin misiniz?", "Ürün Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {


                    _productCrud.Delete(_id);
                    _func.GetAllProductsToDgv(productsDataGridView);
                    choosenProductLabel.Visible = false;
                    editProductPictureBox.ImageLocation = "https://productimages.hepsiburada.net/s/55/375-375/11210049519666.jpg";
                    editProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    deleteProductPictureBox.ImageLocation = "https://i1.imgiz.com/rshots/8100/tutitu-cop-kamyonu-cocuk-oyunlari_8100850-26250_640x360.jpg";
                    deleteProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    _id = 0;
                    MessageBox.Show("Ürün Silme İşlemi Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Ürün Silme İşlemi İptal Edildi!", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Henüz Herhangibir Ürün Seçmediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.Show();
        }
    }
}

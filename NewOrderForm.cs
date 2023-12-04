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
    public partial class NewOrderForm : Form
    {
        Functions _func = new Functions();
        ProductCrud _productCrud = new ProductCrud();
        OrderCruds _orderCruds = new OrderCruds();
        SellProductCruds _sellProductCruds = new SellProductCruds();
        Order _order = new Order();
        List<SellProduct> _sellProductList = new List<SellProduct>();
        int _orderId = 0;
        int _id = 0;
        int _sayacId = 0;
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void productsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(productsDataGridView.CurrentRow.Cells["Id"].Value);

            Product product = _productCrud.GetById(_id);

            choosenOnePictureBox.ImageLocation = product.Image;
            choosenOnePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            choosenOneProductLabel.Visible = true;
            choosenOneProductLabel.Text = product.Name;

            addNewOrderNumericUpDown.Maximum = product.Stock;
            addNewOrderNumericUpDown.Minimum = 1;
            addNewOrderNumericUpDown.Value = 1;


        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            choosenOnePictureBox.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBr-qSjD0HROdf9GzKfBRvDXYA_BUKMlgXBg&usqp=CAU";
            choosenOneProductLabel.Visible = false;
            _func.GetAllProductsToDgv(productsDataGridView);

            orderCardListView.View = View.Details;
            //orderCardListView.GridLines = true;
            orderCardListView.FullRowSelect = true;
            orderCardListView.HideSelection = false;
            orderCardListView.MultiSelect = false;
            //orderCardListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            orderCardListView.Columns.Add("Ürün Adı", 100);
            orderCardListView.Columns.Add("Ürün Fiyatı", 100);
            orderCardListView.Columns.Add("Ürün Adedi", 100);
            orderCardListView.Columns.Add("Ürün Toplam Fiyatı", 100);

            //_order.







        }

        private void addToCardButton_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz. Hiçbir Ürün Seçmediniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _sayacId++;
                SellProduct sellProduct = new SellProduct()
                {
                    Id = _sayacId,
                    OrderId = _orderId,
                    ProductId = _id,
                    Quantity = Convert.ToInt32(addNewOrderNumericUpDown.Value)


                };

                //_sellProductCruds.Add(sellProduct);

                //_order.SellProductList.Add(sellProduct);

                Product product = _productCrud.GetById(sellProduct.ProductId);

                string[] sellProductInformation =
                {

                    product.Name,
                    product.Price.ToString(),
                    sellProduct.Quantity.ToString(),
                   (product.Price * sellProduct.Quantity).ToString(),


                };



                _sellProductList.Add(sellProduct);

                orderCardListView.Items.Add(new ListViewItem(sellProductInformation));




                //_sellProductList.Add(sellProduct);

                //orderCardListView.Items.Add(new ListViewItem(sellProductInformation));




                //MessageBox.Show("Ürün sepete eklendi.");
            }
        }

        private void choosenOneProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearAllCardButton_Click(object sender, EventArgs e)
        {
            orderCardListView.Clear();
            orderCardListView.View = View.Details;
            //orderCardListView.GridLines = true;
            orderCardListView.FullRowSelect = true;
            orderCardListView.HideSelection = false;
            orderCardListView.MultiSelect = false;
            //orderCardListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            orderCardListView.Columns.Add("Ürün Adı", 100);
            orderCardListView.Columns.Add("Ürün Fiyatı", 100);
            orderCardListView.Columns.Add("Ürün Adedi", 100);
            orderCardListView.Columns.Add("Ürün Toplam Fiyatı", 100);

            _sellProductList.Clear();
            _sayacId = 0;
        }

        private void buyAllCardButton_Click(object sender, EventArgs e)
        {
            _sayacId = 0;
            if (_sellProductList.Count == 0)
            {
                MessageBox.Show("Sepetinizde hiçbir ürün bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _order.SellProductList = _sellProductList;
                _order.IsStatus = true;
                _order.UserId = LoginForm._id;

                _orderCruds.Add(_order);

                MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _sellProductList.Clear();
                orderCardListView.Clear();

                orderCardListView.Clear();
                orderCardListView.View = View.Details;
                //orderCardListView.GridLines = true;
                orderCardListView.FullRowSelect = true;
                orderCardListView.HideSelection = false;
                orderCardListView.MultiSelect = false;
                //orderCardListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


                orderCardListView.Columns.Add("Ürün Adı", 100);
                orderCardListView.Columns.Add("Ürün Fiyatı", 100);
                orderCardListView.Columns.Add("Ürün Adedi", 100);
                orderCardListView.Columns.Add("Ürün Toplam Fiyatı", 100);

                _sellProductList.Clear();
                _sayacId = 0;
            }
        }
    }
}

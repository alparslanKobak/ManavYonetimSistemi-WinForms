namespace MarketYönetimSistemi
{
    partial class NewOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderCardListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.clearAllCardButton = new System.Windows.Forms.Button();
            this.buyAllCardButton = new System.Windows.Forms.Button();
            this.choosenOnePictureBox = new System.Windows.Forms.PictureBox();
            this.choosenOneProductLabel = new System.Windows.Forms.Label();
            this.addNewOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCardButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosenOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewOrderNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(534, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Order";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(41, 165);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(462, 347);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellDoubleClick);
            // 
            // orderCardListView
            // 
            this.orderCardListView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderCardListView.ForeColor = System.Drawing.Color.Lime;
            this.orderCardListView.HideSelection = false;
            this.orderCardListView.Location = new System.Drawing.Point(907, 165);
            this.orderCardListView.Name = "orderCardListView";
            this.orderCardListView.Size = new System.Drawing.Size(543, 347);
            this.orderCardListView.TabIndex = 3;
            this.orderCardListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1152, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "My Card";
            // 
            // clearAllCardButton
            // 
            this.clearAllCardButton.BackColor = System.Drawing.Color.Red;
            this.clearAllCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearAllCardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearAllCardButton.Location = new System.Drawing.Point(1001, 534);
            this.clearAllCardButton.Name = "clearAllCardButton";
            this.clearAllCardButton.Size = new System.Drawing.Size(117, 31);
            this.clearAllCardButton.TabIndex = 8;
            this.clearAllCardButton.Text = "Clear";
            this.clearAllCardButton.UseVisualStyleBackColor = false;
            // 
            // buyAllCardButton
            // 
            this.buyAllCardButton.BackColor = System.Drawing.Color.ForestGreen;
            this.buyAllCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buyAllCardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buyAllCardButton.Location = new System.Drawing.Point(1229, 534);
            this.buyAllCardButton.Name = "buyAllCardButton";
            this.buyAllCardButton.Size = new System.Drawing.Size(117, 31);
            this.buyAllCardButton.TabIndex = 9;
            this.buyAllCardButton.Text = "Buy";
            this.buyAllCardButton.UseVisualStyleBackColor = false;
            // 
            // choosenOnePictureBox
            // 
            this.choosenOnePictureBox.Location = new System.Drawing.Point(545, 199);
            this.choosenOnePictureBox.Name = "choosenOnePictureBox";
            this.choosenOnePictureBox.Size = new System.Drawing.Size(257, 151);
            this.choosenOnePictureBox.TabIndex = 10;
            this.choosenOnePictureBox.TabStop = false;
            // 
            // choosenOneProductLabel
            // 
            this.choosenOneProductLabel.AutoSize = true;
            this.choosenOneProductLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosenOneProductLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.choosenOneProductLabel.Location = new System.Drawing.Point(585, 150);
            this.choosenOneProductLabel.Name = "choosenOneProductLabel";
            this.choosenOneProductLabel.Size = new System.Drawing.Size(173, 23);
            this.choosenOneProductLabel.TabIndex = 11;
            this.choosenOneProductLabel.Text = "Seçili Ürün Label : ";
            this.choosenOneProductLabel.Click += new System.EventHandler(this.choosenOneProductLabel_Click);
            // 
            // addNewOrderNumericUpDown
            // 
            this.addNewOrderNumericUpDown.Location = new System.Drawing.Point(649, 384);
            this.addNewOrderNumericUpDown.Name = "addNewOrderNumericUpDown";
            this.addNewOrderNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.addNewOrderNumericUpDown.TabIndex = 12;
            // 
            // addToCardButton
            // 
            this.addToCardButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addToCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addToCardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addToCardButton.Location = new System.Drawing.Point(612, 436);
            this.addToCardButton.Name = "addToCardButton";
            this.addToCardButton.Size = new System.Drawing.Size(117, 31);
            this.addToCardButton.TabIndex = 14;
            this.addToCardButton.Text = "Add To Card";
            this.addToCardButton.UseVisualStyleBackColor = false;
            this.addToCardButton.Click += new System.EventHandler(this.addToCardButton_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1462, 599);
            this.Controls.Add(this.addToCardButton);
            this.Controls.Add(this.addNewOrderNumericUpDown);
            this.Controls.Add(this.choosenOneProductLabel);
            this.Controls.Add(this.choosenOnePictureBox);
            this.Controls.Add(this.buyAllCardButton);
            this.Controls.Add(this.clearAllCardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderCardListView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrderForm";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosenOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewOrderNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.ListView orderCardListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearAllCardButton;
        private System.Windows.Forms.Button buyAllCardButton;
        private System.Windows.Forms.PictureBox choosenOnePictureBox;
        private System.Windows.Forms.Label choosenOneProductLabel;
        private System.Windows.Forms.NumericUpDown addNewOrderNumericUpDown;
        private System.Windows.Forms.Button addToCardButton;
    }
}
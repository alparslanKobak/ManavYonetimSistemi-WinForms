namespace MarketYönetimSistemi
{
    partial class UpdateProductForm
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
            this.updateProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageUploadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateProductNameTextBox = new System.Windows.Forms.TextBox();
            this.updateProductPictureBox = new System.Windows.Forms.PictureBox();
            this.updateProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.updateStockValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.updatePriceValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.updateProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateStockValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePriceValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Product";
            // 
            // updateProductButton
            // 
            this.updateProductButton.BackColor = System.Drawing.Color.ForestGreen;
            this.updateProductButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateProductButton.Location = new System.Drawing.Point(171, 519);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(163, 46);
            this.updateProductButton.TabIndex = 32;
            this.updateProductButton.Text = "Update Product";
            this.updateProductButton.UseVisualStyleBackColor = false;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(47, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Price Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(43, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Stock Value";
            // 
            // imageUploadButton
            // 
            this.imageUploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.imageUploadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageUploadButton.Location = new System.Drawing.Point(133, 256);
            this.imageUploadButton.Name = "imageUploadButton";
            this.imageUploadButton.Size = new System.Drawing.Size(219, 22);
            this.imageUploadButton.TabIndex = 27;
            this.imageUploadButton.Text = "Upload A Product Image";
            this.imageUploadButton.UseVisualStyleBackColor = false;
            this.imageUploadButton.Click += new System.EventHandler(this.imageUploadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(0, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(23, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Product Name";
            // 
            // updateProductNameTextBox
            // 
            this.updateProductNameTextBox.Location = new System.Drawing.Point(171, 323);
            this.updateProductNameTextBox.Name = "updateProductNameTextBox";
            this.updateProductNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.updateProductNameTextBox.TabIndex = 23;
            // 
            // updateProductPictureBox
            // 
            this.updateProductPictureBox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.updateProductPictureBox.Location = new System.Drawing.Point(133, 106);
            this.updateProductPictureBox.Name = "updateProductPictureBox";
            this.updateProductPictureBox.Size = new System.Drawing.Size(219, 128);
            this.updateProductPictureBox.TabIndex = 22;
            this.updateProductPictureBox.TabStop = false;
            // 
            // updateProductCategoryComboBox
            // 
            this.updateProductCategoryComboBox.FormattingEnabled = true;
            this.updateProductCategoryComboBox.Location = new System.Drawing.Point(171, 357);
            this.updateProductCategoryComboBox.Name = "updateProductCategoryComboBox";
            this.updateProductCategoryComboBox.Size = new System.Drawing.Size(163, 21);
            this.updateProductCategoryComboBox.TabIndex = 33;
            // 
            // updateStockValueNumericUpDown
            // 
            this.updateStockValueNumericUpDown.Location = new System.Drawing.Point(171, 397);
            this.updateStockValueNumericUpDown.Name = "updateStockValueNumericUpDown";
            this.updateStockValueNumericUpDown.Size = new System.Drawing.Size(163, 20);
            this.updateStockValueNumericUpDown.TabIndex = 34;
            // 
            // updatePriceValueNumericUpDown
            // 
            this.updatePriceValueNumericUpDown.Location = new System.Drawing.Point(171, 435);
            this.updatePriceValueNumericUpDown.Name = "updatePriceValueNumericUpDown";
            this.updatePriceValueNumericUpDown.Size = new System.Drawing.Size(163, 20);
            this.updatePriceValueNumericUpDown.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(43, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Description";
            // 
            // updateProductDescriptionTextBox
            // 
            this.updateProductDescriptionTextBox.Location = new System.Drawing.Point(171, 468);
            this.updateProductDescriptionTextBox.Name = "updateProductDescriptionTextBox";
            this.updateProductDescriptionTextBox.Size = new System.Drawing.Size(163, 20);
            this.updateProductDescriptionTextBox.TabIndex = 36;
            this.updateProductDescriptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(486, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateProductDescriptionTextBox);
            this.Controls.Add(this.updatePriceValueNumericUpDown);
            this.Controls.Add(this.updateStockValueNumericUpDown);
            this.Controls.Add(this.updateProductCategoryComboBox);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageUploadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateProductNameTextBox);
            this.Controls.Add(this.updateProductPictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateStockValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePriceValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button imageUploadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateProductNameTextBox;
        private System.Windows.Forms.PictureBox updateProductPictureBox;
        private System.Windows.Forms.ComboBox updateProductCategoryComboBox;
        private System.Windows.Forms.NumericUpDown updateStockValueNumericUpDown;
        private System.Windows.Forms.NumericUpDown updatePriceValueNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateProductDescriptionTextBox;
    }
}
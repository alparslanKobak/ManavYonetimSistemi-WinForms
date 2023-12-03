namespace MarketYönetimSistemi
{
    partial class AllProductsForm
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
            this.editProductPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteProductPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.choosenProductLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Products";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(29, 144);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(462, 311);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellDoubleClick);
            // 
            // editProductPictureBox
            // 
            this.editProductPictureBox.Location = new System.Drawing.Point(517, 158);
            this.editProductPictureBox.Name = "editProductPictureBox";
            this.editProductPictureBox.Size = new System.Drawing.Size(207, 183);
            this.editProductPictureBox.TabIndex = 2;
            this.editProductPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(749, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Throw Away Product";
            // 
            // deleteProductPictureBox
            // 
            this.deleteProductPictureBox.Location = new System.Drawing.Point(739, 158);
            this.deleteProductPictureBox.Name = "deleteProductPictureBox";
            this.deleteProductPictureBox.Size = new System.Drawing.Size(207, 183);
            this.deleteProductPictureBox.TabIndex = 4;
            this.deleteProductPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(559, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edit Product";
            // 
            // editProductButton
            // 
            this.editProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editProductButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editProductButton.Location = new System.Drawing.Point(563, 398);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(117, 31);
            this.editProductButton.TabIndex = 6;
            this.editProductButton.Text = "Update";
            this.editProductButton.UseVisualStyleBackColor = false;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.Red;
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProductButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteProductButton.Location = new System.Drawing.Point(782, 398);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(117, 31);
            this.deleteProductButton.TabIndex = 7;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // choosenProductLabel
            // 
            this.choosenProductLabel.AutoSize = true;
            this.choosenProductLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosenProductLabel.Location = new System.Drawing.Point(636, 121);
            this.choosenProductLabel.Name = "choosenProductLabel";
            this.choosenProductLabel.Size = new System.Drawing.Size(216, 23);
            this.choosenProductLabel.TabIndex = 8;
            this.choosenProductLabel.Text = "Choosen Product Label";
            // 
            // AllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(958, 542);
            this.Controls.Add(this.choosenProductLabel);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteProductPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editProductPictureBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AllProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllProductsForm";
            this.Load += new System.EventHandler(this.AllProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.PictureBox editProductPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox deleteProductPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label choosenProductLabel;
    }
}
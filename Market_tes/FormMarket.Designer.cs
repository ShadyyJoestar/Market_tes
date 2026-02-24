namespace Market_tes
{
    partial class FormMarket
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
            dgvProducts = new DataGridView();
            txtName = new TextBox();
            label1 = new Label();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnadd = new Button();
            btnclr = new Button();
            btndel = new Button();
            btnupdt = new Button();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Top;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1260, 188);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 275);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 278);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(578, 271);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(264, 27);
            txtStock.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(146, 409);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(264, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(146, 344);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(264, 27);
            txtCategory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 351);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 416);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 278);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 9;
            label4.Text = "Stock";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(187, 463);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 49);
            btnadd.TabIndex = 10;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnclr
            // 
            btnclr.Location = new Point(643, 463);
            btnclr.Name = "btnclr";
            btnclr.Size = new Size(94, 49);
            btnclr.TabIndex = 11;
            btnclr.Text = "Clear";
            btnclr.UseVisualStyleBackColor = true;
            btnclr.Click += btnclr_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(489, 463);
            btndel.Name = "btndel";
            btndel.Size = new Size(94, 49);
            btndel.TabIndex = 12;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnupdt
            // 
            btnupdt.Location = new Point(331, 463);
            btnupdt.Name = "btnupdt";
            btnupdt.Size = new Size(94, 49);
            btnupdt.TabIndex = 13;
            btnupdt.Text = "Update";
            btnupdt.UseVisualStyleBackColor = true;
            btnupdt.Click += btnupdt_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(820, 463);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(116, 46);
            btnLogOut.TabIndex = 14;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FormMarket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 587);
            Controls.Add(btnLogOut);
            Controls.Add(btnupdt);
            Controls.Add(btndel);
            Controls.Add(btnclr);
            Controls.Add(btnadd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dgvProducts);
            Name = "FormMarket";
            Text = "FormMarket";
            Load += FormMarket_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtName;
        private Label label1;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnadd;
        private Button btnclr;
        private Button btndel;
        private Button btnupdt;
        private Button btnLogOut;
    }
}
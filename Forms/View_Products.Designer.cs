namespace Order_Management_System___OODJ.Forms
{
    partial class View_Products
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
            this.components = new System.ComponentModel.Container();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.ViewProductIdTxtBx = new System.Windows.Forms.TextBox();
            this.ViewProductsSrchBtn = new System.Windows.Forms.Button();
            this.ViewProductsRldataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AutoGenerateColumns = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productRateDataGridViewTextBoxColumn,
            this.Delete});
            this.ProductsDataGridView.DataSource = this.productBindingSource;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 95);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.Size = new System.Drawing.Size(1125, 493);
            this.ProductsDataGridView.TabIndex = 0;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "ProductName";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete Product";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // ViewProductNameTxtBx
            // 
            this.ViewProductNameTxtBx.Location = new System.Drawing.Point(948, 32);
            this.ViewProductNameTxtBx.Name = "ViewProductNameTxtBx";
            this.ViewProductNameTxtBx.Size = new System.Drawing.Size(154, 22);
            this.ViewProductNameTxtBx.TabIndex = 1;
            // 
            // ViewProductIdTxtBx
            // 
            this.ViewProductIdTxtBx.Location = new System.Drawing.Point(112, 32);
            this.ViewProductIdTxtBx.Name = "ViewProductIdTxtBx";
            this.ViewProductIdTxtBx.Size = new System.Drawing.Size(154, 22);
            this.ViewProductIdTxtBx.TabIndex = 2;
            // 
            // ViewProductsSrchBtn
            // 
            this.ViewProductsSrchBtn.Location = new System.Drawing.Point(330, 21);
            this.ViewProductsSrchBtn.Name = "ViewProductsSrchBtn";
            this.ViewProductsSrchBtn.Size = new System.Drawing.Size(141, 45);
            this.ViewProductsSrchBtn.TabIndex = 3;
            this.ViewProductsSrchBtn.Text = "Search";
            this.ViewProductsSrchBtn.UseVisualStyleBackColor = true;
            this.ViewProductsSrchBtn.Click += new System.EventHandler(this.ViewProductsSrchBtn_Click);
            // 
            // ViewProductsRldataBtn
            // 
            this.ViewProductsRldataBtn.Location = new System.Drawing.Point(645, 21);
            this.ViewProductsRldataBtn.Name = "ViewProductsRldataBtn";
            this.ViewProductsRldataBtn.Size = new System.Drawing.Size(141, 45);
            this.ViewProductsRldataBtn.TabIndex = 4;
            this.ViewProductsRldataBtn.Text = "Reload Table";
            this.ViewProductsRldataBtn.UseVisualStyleBackColor = true;
            this.ViewProductsRldataBtn.Click += new System.EventHandler(this.ViewProductsRldataBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productDescDataGridViewTextBoxColumn
            // 
            this.productDescDataGridViewTextBoxColumn.DataPropertyName = "ProductDesc";
            this.productDescDataGridViewTextBoxColumn.HeaderText = "ProductDesc";
            this.productDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDescDataGridViewTextBoxColumn.Name = "productDescDataGridViewTextBoxColumn";
            this.productDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDescDataGridViewTextBoxColumn.Width = 250;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productRateDataGridViewTextBoxColumn
            // 
            this.productRateDataGridViewTextBoxColumn.DataPropertyName = "ProductRate";
            this.productRateDataGridViewTextBoxColumn.HeaderText = "ProductRate";
            this.productRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productRateDataGridViewTextBoxColumn.Name = "productRateDataGridViewTextBoxColumn";
            this.productRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Order_Management_System___OODJ.models.Product);
            // 
            // View_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewProductsRldataBtn);
            this.Controls.Add(this.ViewProductsSrchBtn);
            this.Controls.Add(this.ViewProductIdTxtBx);
            this.Controls.Add(this.ViewProductNameTxtBx);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "View_Products";
            this.Text = "View_Products";
            this.Load += new System.EventHandler(this.View_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox ViewProductNameTxtBx;
        private System.Windows.Forms.TextBox ViewProductIdTxtBx;
        private System.Windows.Forms.Button ViewProductsSrchBtn;
        private System.Windows.Forms.Button ViewProductsRldataBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
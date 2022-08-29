namespace Order_Management_System___OODJ.Forms
{
    partial class Add_Product
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
            this.AddProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.AddProductRateTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.AddProductDescTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddProductNameTxtBx
            // 
            this.AddProductNameTxtBx.Location = new System.Drawing.Point(514, 161);
            this.AddProductNameTxtBx.Name = "AddProductNameTxtBx";
            this.AddProductNameTxtBx.Size = new System.Drawing.Size(287, 22);
            this.AddProductNameTxtBx.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddProductPriceTxtBx
            // 
            this.AddProductPriceTxtBx.Location = new System.Drawing.Point(514, 313);
            this.AddProductPriceTxtBx.Name = "AddProductPriceTxtBx";
            this.AddProductPriceTxtBx.Size = new System.Drawing.Size(287, 22);
            this.AddProductPriceTxtBx.TabIndex = 2;
            // 
            // AddProductRateTxtBx
            // 
            this.AddProductRateTxtBx.Location = new System.Drawing.Point(514, 363);
            this.AddProductRateTxtBx.Name = "AddProductRateTxtBx";
            this.AddProductRateTxtBx.Size = new System.Drawing.Size(287, 22);
            this.AddProductRateTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Rate";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(514, 429);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(287, 38);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // AddProductDescTxtBx
            // 
            this.AddProductDescTxtBx.Location = new System.Drawing.Point(514, 245);
            this.AddProductDescTxtBx.Name = "AddProductDescTxtBx";
            this.AddProductDescTxtBx.Size = new System.Drawing.Size(287, 22);
            this.AddProductDescTxtBx.TabIndex = 10;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 481);
            this.Controls.Add(this.AddProductDescTxtBx);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProductRateTxtBx);
            this.Controls.Add(this.AddProductPriceTxtBx);
            this.Controls.Add(this.AddProductNameTxtBx);
            this.MaximumSize = new System.Drawing.Size(1175, 649);
            this.MinimumSize = new System.Drawing.Size(1175, 649);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddProductNameTxtBx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AddProductPriceTxtBx;
        private System.Windows.Forms.TextBox AddProductRateTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.TextBox AddProductDescTxtBx;
    }
}
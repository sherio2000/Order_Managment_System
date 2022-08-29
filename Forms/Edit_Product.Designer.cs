namespace Order_Management_System___OODJ.Forms
{
    partial class Edit_Product
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
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditProductRateTxtBx = new System.Windows.Forms.TextBox();
            this.EditProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.EditProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.EditProductComboBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EditProductDescTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(586, 498);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(261, 38);
            this.EditProductBtn.TabIndex = 18;
            this.EditProductBtn.Text = "Update Product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Name";
            // 
            // EditProductRateTxtBx
            // 
            this.EditProductRateTxtBx.Location = new System.Drawing.Point(586, 416);
            this.EditProductRateTxtBx.Name = "EditProductRateTxtBx";
            this.EditProductRateTxtBx.Size = new System.Drawing.Size(261, 22);
            this.EditProductRateTxtBx.TabIndex = 13;
            // 
            // EditProductPriceTxtBx
            // 
            this.EditProductPriceTxtBx.Location = new System.Drawing.Point(586, 353);
            this.EditProductPriceTxtBx.Name = "EditProductPriceTxtBx";
            this.EditProductPriceTxtBx.Size = new System.Drawing.Size(261, 22);
            this.EditProductPriceTxtBx.TabIndex = 11;
            // 
            // EditProductNameTxtBx
            // 
            this.EditProductNameTxtBx.Location = new System.Drawing.Point(586, 213);
            this.EditProductNameTxtBx.Name = "EditProductNameTxtBx";
            this.EditProductNameTxtBx.Size = new System.Drawing.Size(261, 22);
            this.EditProductNameTxtBx.TabIndex = 10;
            // 
            // EditProductComboBx
            // 
            this.EditProductComboBx.FormattingEnabled = true;
            this.EditProductComboBx.Location = new System.Drawing.Point(586, 53);
            this.EditProductComboBx.Name = "EditProductComboBx";
            this.EditProductComboBx.Size = new System.Drawing.Size(261, 24);
            this.EditProductComboBx.TabIndex = 19;
            this.EditProductComboBx.SelectedValueChanged += new System.EventHandler(this.EditProductComboBx_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Choose Product";
            // 
            // EditProductDescTxtBx
            // 
            this.EditProductDescTxtBx.Location = new System.Drawing.Point(586, 286);
            this.EditProductDescTxtBx.Name = "EditProductDescTxtBx";
            this.EditProductDescTxtBx.Size = new System.Drawing.Size(261, 22);
            this.EditProductDescTxtBx.TabIndex = 21;
            // 
            // Edit_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 602);
            this.Controls.Add(this.EditProductDescTxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditProductComboBx);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditProductRateTxtBx);
            this.Controls.Add(this.EditProductPriceTxtBx);
            this.Controls.Add(this.EditProductNameTxtBx);
            this.MaximumSize = new System.Drawing.Size(1175, 649);
            this.MinimumSize = new System.Drawing.Size(1175, 649);
            this.Name = "Edit_Product";
            this.Text = "Edit_Product";
            this.Load += new System.EventHandler(this.Edit_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditProductRateTxtBx;
        private System.Windows.Forms.TextBox EditProductPriceTxtBx;
        private System.Windows.Forms.TextBox EditProductNameTxtBx;
        private System.Windows.Forms.ComboBox EditProductComboBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EditProductDescTxtBx;
    }
}
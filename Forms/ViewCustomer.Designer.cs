namespace Order_Management_System___OODJ.Forms
{
    partial class ViewCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCustomerFullNameLbl = new System.Windows.Forms.Label();
            this.ViewCustomerEmailAddressLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewCustomerUserNameLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Full Name :";
            // 
            // ViewCustomerFullNameLbl
            // 
            this.ViewCustomerFullNameLbl.AutoSize = true;
            this.ViewCustomerFullNameLbl.Location = new System.Drawing.Point(394, 107);
            this.ViewCustomerFullNameLbl.Name = "ViewCustomerFullNameLbl";
            this.ViewCustomerFullNameLbl.Size = new System.Drawing.Size(44, 16);
            this.ViewCustomerFullNameLbl.TabIndex = 1;
            this.ViewCustomerFullNameLbl.Text = "label2";
            // 
            // ViewCustomerEmailAddressLbl
            // 
            this.ViewCustomerEmailAddressLbl.AutoSize = true;
            this.ViewCustomerEmailAddressLbl.Location = new System.Drawing.Point(394, 166);
            this.ViewCustomerEmailAddressLbl.Name = "ViewCustomerEmailAddressLbl";
            this.ViewCustomerEmailAddressLbl.Size = new System.Drawing.Size(44, 16);
            this.ViewCustomerEmailAddressLbl.TabIndex = 3;
            this.ViewCustomerEmailAddressLbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Email Address :";
            // 
            // ViewCustomerUserNameLbl
            // 
            this.ViewCustomerUserNameLbl.AutoSize = true;
            this.ViewCustomerUserNameLbl.Location = new System.Drawing.Point(394, 224);
            this.ViewCustomerUserNameLbl.Name = "ViewCustomerUserNameLbl";
            this.ViewCustomerUserNameLbl.Size = new System.Drawing.Size(44, 16);
            this.ViewCustomerUserNameLbl.TabIndex = 5;
            this.ViewCustomerUserNameLbl.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer User Name :";
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewCustomerUserNameLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViewCustomerEmailAddressLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewCustomerFullNameLbl);
            this.Controls.Add(this.label1);
            this.Name = "ViewCustomer";
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ViewCustomerFullNameLbl;
        private System.Windows.Forms.Label ViewCustomerEmailAddressLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ViewCustomerUserNameLbl;
        private System.Windows.Forms.Label label6;
    }
}
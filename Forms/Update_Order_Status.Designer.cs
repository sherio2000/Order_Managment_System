namespace Order_Management_System___OODJ.Forms
{
    partial class Update_Order_Status
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
            this.UpdateOrderStatusCurrentStatusLbl = new System.Windows.Forms.Label();
            this.UpdateOrderStsCmboBx = new System.Windows.Forms.ComboBox();
            this.UpdateOrderStatusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Status : ";
            // 
            // UpdateOrderStatusCurrentStatusLbl
            // 
            this.UpdateOrderStatusCurrentStatusLbl.AutoSize = true;
            this.UpdateOrderStatusCurrentStatusLbl.Location = new System.Drawing.Point(457, 92);
            this.UpdateOrderStatusCurrentStatusLbl.Name = "UpdateOrderStatusCurrentStatusLbl";
            this.UpdateOrderStatusCurrentStatusLbl.Size = new System.Drawing.Size(44, 16);
            this.UpdateOrderStatusCurrentStatusLbl.TabIndex = 1;
            this.UpdateOrderStatusCurrentStatusLbl.Text = "label2";
            // 
            // UpdateOrderStsCmboBx
            // 
            this.UpdateOrderStsCmboBx.FormattingEnabled = true;
            this.UpdateOrderStsCmboBx.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "In Progress",
            "Rejected",
            "Cancelled"});
            this.UpdateOrderStsCmboBx.Location = new System.Drawing.Point(306, 172);
            this.UpdateOrderStsCmboBx.Name = "UpdateOrderStsCmboBx";
            this.UpdateOrderStsCmboBx.Size = new System.Drawing.Size(195, 24);
            this.UpdateOrderStsCmboBx.TabIndex = 2;
            // 
            // UpdateOrderStatusBtn
            // 
            this.UpdateOrderStatusBtn.Location = new System.Drawing.Point(306, 213);
            this.UpdateOrderStatusBtn.Name = "UpdateOrderStatusBtn";
            this.UpdateOrderStatusBtn.Size = new System.Drawing.Size(195, 26);
            this.UpdateOrderStatusBtn.TabIndex = 3;
            this.UpdateOrderStatusBtn.Text = "Update";
            this.UpdateOrderStatusBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderStatusBtn.Click += new System.EventHandler(this.UpdateOrderStatusBtn_Click);
            // 
            // Update_Order_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateOrderStatusBtn);
            this.Controls.Add(this.UpdateOrderStsCmboBx);
            this.Controls.Add(this.UpdateOrderStatusCurrentStatusLbl);
            this.Controls.Add(this.label1);
            this.Name = "Update_Order_Status";
            this.Text = "Update_Order_Status";
            this.Load += new System.EventHandler(this.Update_Order_Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateOrderStatusCurrentStatusLbl;
        private System.Windows.Forms.ComboBox UpdateOrderStsCmboBx;
        private System.Windows.Forms.Button UpdateOrderStatusBtn;
    }
}
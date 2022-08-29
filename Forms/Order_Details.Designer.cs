namespace Order_Management_System___OODJ.Forms
{
    partial class Order_Details
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
            this.orderItemsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // orderItemsRichTextBox
            // 
            this.orderItemsRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.orderItemsRichTextBox.Name = "orderItemsRichTextBox";
            this.orderItemsRichTextBox.ReadOnly = true;
            this.orderItemsRichTextBox.Size = new System.Drawing.Size(776, 426);
            this.orderItemsRichTextBox.TabIndex = 0;
            this.orderItemsRichTextBox.Text = "";
            // 
            // Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderItemsRichTextBox);
            this.Name = "Order_Details";
            this.Text = "Order_Details";
            this.Load += new System.EventHandler(this.Order_Details_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox orderItemsRichTextBox;
    }
}
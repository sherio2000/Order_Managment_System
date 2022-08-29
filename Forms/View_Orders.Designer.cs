namespace Order_Management_System___OODJ.Forms
{
    partial class View_Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewOrdersRldataBtn = new System.Windows.Forms.Button();
            this.ViewOrdersSrchBtn = new System.Windows.Forms.Button();
            this.ViewOrderIdTxtBx = new System.Windows.Forms.TextBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewOrderDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updateStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderStatusCmboBx = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order Id";
            // 
            // ViewOrdersRldataBtn
            // 
            this.ViewOrdersRldataBtn.Location = new System.Drawing.Point(749, 6);
            this.ViewOrdersRldataBtn.Name = "ViewOrdersRldataBtn";
            this.ViewOrdersRldataBtn.Size = new System.Drawing.Size(141, 45);
            this.ViewOrdersRldataBtn.TabIndex = 11;
            this.ViewOrdersRldataBtn.Text = "Reload Table";
            this.ViewOrdersRldataBtn.UseVisualStyleBackColor = true;
            this.ViewOrdersRldataBtn.Click += new System.EventHandler(this.ViewOrdersRldataBtn_Click);
            // 
            // ViewOrdersSrchBtn
            // 
            this.ViewOrdersSrchBtn.Location = new System.Drawing.Point(380, 6);
            this.ViewOrdersSrchBtn.Name = "ViewOrdersSrchBtn";
            this.ViewOrdersSrchBtn.Size = new System.Drawing.Size(141, 45);
            this.ViewOrdersSrchBtn.TabIndex = 10;
            this.ViewOrdersSrchBtn.Text = "Search";
            this.ViewOrdersSrchBtn.UseVisualStyleBackColor = true;
            this.ViewOrdersSrchBtn.Click += new System.EventHandler(this.ViewOrdersSrchBtn_Click);
            // 
            // ViewOrderIdTxtBx
            // 
            this.ViewOrderIdTxtBx.Location = new System.Drawing.Point(162, 17);
            this.ViewOrderIdTxtBx.Name = "ViewOrderIdTxtBx";
            this.ViewOrderIdTxtBx.Size = new System.Drawing.Size(154, 22);
            this.ViewOrderIdTxtBx.TabIndex = 9;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AutoGenerateColumns = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.ViewOrderDetails,
            this.ViewCustomer,
            this.updateStatus});
            this.OrdersDataGridView.DataSource = this.orderBindingSource;
            this.OrdersDataGridView.Location = new System.Drawing.Point(36, 57);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.OrdersDataGridView.Size = new System.Drawing.Size(1112, 613);
            this.OrdersDataGridView.TabIndex = 7;
            this.OrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentClick);
            // 
            // ViewOrderDetails
            // 
            this.ViewOrderDetails.HeaderText = "View Details";
            this.ViewOrderDetails.MinimumWidth = 6;
            this.ViewOrderDetails.Name = "ViewOrderDetails";
            this.ViewOrderDetails.ReadOnly = true;
            this.ViewOrderDetails.Text = "View Details";
            this.ViewOrderDetails.UseColumnTextForButtonValue = true;
            this.ViewOrderDetails.Width = 125;
            // 
            // ViewCustomer
            // 
            this.ViewCustomer.DataPropertyName = "UserId";
            this.ViewCustomer.HeaderText = "View Customer";
            this.ViewCustomer.MinimumWidth = 6;
            this.ViewCustomer.Name = "ViewCustomer";
            this.ViewCustomer.ReadOnly = true;
            this.ViewCustomer.Text = "View Customer";
            this.ViewCustomer.UseColumnTextForButtonValue = true;
            this.ViewCustomer.Width = 125;
            // 
            // updateStatus
            // 
            this.updateStatus.HeaderText = "Update Status";
            this.updateStatus.MinimumWidth = 6;
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.ReadOnly = true;
            this.updateStatus.Text = "Update Status";
            this.updateStatus.UseColumnTextForButtonValue = true;
            this.updateStatus.Width = 125;
            // 
            // orderStatusCmboBx
            // 
            this.orderStatusCmboBx.FormattingEnabled = true;
            this.orderStatusCmboBx.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "In Progress",
            "Rejected",
            "Cancelled"});
            this.orderStatusCmboBx.Location = new System.Drawing.Point(946, 17);
            this.orderStatusCmboBx.Name = "orderStatusCmboBx";
            this.orderStatusCmboBx.Size = new System.Drawing.Size(202, 24);
            this.orderStatusCmboBx.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "Order Total";
            this.orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "Order Status";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Order_Management_System___OODJ.models.Order);
            // 
            // View_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.orderStatusCmboBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewOrdersRldataBtn);
            this.Controls.Add(this.ViewOrdersSrchBtn);
            this.Controls.Add(this.ViewOrderIdTxtBx);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "View_Orders";
            this.Text = "View_Orders";
            this.Load += new System.EventHandler(this.View_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewOrdersRldataBtn;
        private System.Windows.Forms.Button ViewOrdersSrchBtn;
        private System.Windows.Forms.TextBox ViewOrderIdTxtBx;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ComboBox orderStatusCmboBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewOrderDetails;
        private System.Windows.Forms.DataGridViewButtonColumn ViewCustomer;
        private System.Windows.Forms.DataGridViewButtonColumn updateStatus;
    }
}
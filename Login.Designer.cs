namespace Order_Management_System___OODJ
{
    partial class LoginForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LoginScreenLabel = new System.Windows.Forms.Label();
            this.LoginEmailTxtBx = new System.Windows.Forms.TextBox();
            this.LoginPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginEmailLbl = new System.Windows.Forms.Label();
            this.LoginPasswordLbl = new System.Windows.Forms.Label();
            this.LoginExitBtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(288, 691);
            this.panelMenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 102);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel4.Controls.Add(this.LoginScreenLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(288, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 102);
            this.panel4.TabIndex = 3;
            // 
            // LoginScreenLabel
            // 
            this.LoginScreenLabel.AutoSize = true;
            this.LoginScreenLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginScreenLabel.Location = new System.Drawing.Point(425, 31);
            this.LoginScreenLabel.Name = "LoginScreenLabel";
            this.LoginScreenLabel.Size = new System.Drawing.Size(156, 48);
            this.LoginScreenLabel.TabIndex = 0;
            this.LoginScreenLabel.Text = "Login";
            this.LoginScreenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginEmailTxtBx
            // 
            this.LoginEmailTxtBx.Location = new System.Drawing.Point(683, 327);
            this.LoginEmailTxtBx.Name = "LoginEmailTxtBx";
            this.LoginEmailTxtBx.Size = new System.Drawing.Size(191, 22);
            this.LoginEmailTxtBx.TabIndex = 4;
            // 
            // LoginPasswordTxtBx
            // 
            this.LoginPasswordTxtBx.Location = new System.Drawing.Point(683, 374);
            this.LoginPasswordTxtBx.Name = "LoginPasswordTxtBx";
            this.LoginPasswordTxtBx.PasswordChar = '*';
            this.LoginPasswordTxtBx.Size = new System.Drawing.Size(191, 22);
            this.LoginPasswordTxtBx.TabIndex = 5;
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(683, 426);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(191, 34);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginEmailLbl
            // 
            this.LoginEmailLbl.AutoSize = true;
            this.LoginEmailLbl.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmailLbl.Location = new System.Drawing.Point(570, 327);
            this.LoginEmailLbl.Name = "LoginEmailLbl";
            this.LoginEmailLbl.Size = new System.Drawing.Size(61, 21);
            this.LoginEmailLbl.TabIndex = 7;
            this.LoginEmailLbl.Text = "Email ";
            this.LoginEmailLbl.UseWaitCursor = true;
            // 
            // LoginPasswordLbl
            // 
            this.LoginPasswordLbl.AutoSize = true;
            this.LoginPasswordLbl.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold);
            this.LoginPasswordLbl.Location = new System.Drawing.Point(568, 374);
            this.LoginPasswordLbl.Name = "LoginPasswordLbl";
            this.LoginPasswordLbl.Size = new System.Drawing.Size(87, 21);
            this.LoginPasswordLbl.TabIndex = 8;
            this.LoginPasswordLbl.Text = "Password";
            this.LoginPasswordLbl.Click += new System.EventHandler(this.LoginPasswordLbl_Click_1);
            // 
            // LoginExitBtn
            // 
            this.LoginExitBtn.Image = global::Order_Management_System___OODJ.Properties.Resources.logout_icon;
            this.LoginExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginExitBtn.Location = new System.Drawing.Point(1171, 576);
            this.LoginExitBtn.Name = "LoginExitBtn";
            this.LoginExitBtn.Size = new System.Drawing.Size(172, 61);
            this.LoginExitBtn.TabIndex = 9;
            this.LoginExitBtn.Text = "Exit";
            this.LoginExitBtn.UseVisualStyleBackColor = true;
            this.LoginExitBtn.Click += new System.EventHandler(this.LoginExitBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 691);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LoginExitBtn);
            this.Controls.Add(this.LoginPasswordLbl);
            this.Controls.Add(this.LoginEmailLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginPasswordTxtBx);
            this.Controls.Add(this.LoginEmailTxtBx);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LoginScreenLabel;
        private System.Windows.Forms.TextBox LoginEmailTxtBx;
        private System.Windows.Forms.TextBox LoginPasswordTxtBx;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label LoginEmailLbl;
        private System.Windows.Forms.Label LoginPasswordLbl;
        private System.Windows.Forms.Button LoginExitBtn;
    }
}


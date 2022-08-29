namespace Order_Management_System___OODJ.Forms
{
    partial class Profile
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
            this.ProfileFullNameTxtBx = new System.Windows.Forms.TextBox();
            this.ProfilePswdTxtBx = new System.Windows.Forms.TextBox();
            this.ProfileUserRoleTxtBx = new System.Windows.Forms.TextBox();
            this.ProfileEmailTxtBx = new System.Windows.Forms.TextBox();
            this.ProfileUserNameTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfileUpdateBtn = new System.Windows.Forms.Button();
            this.ProfileShowPasswordChkBx = new System.Windows.Forms.CheckBox();
            this.ProfileResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileFullNameTxtBx
            // 
            this.ProfileFullNameTxtBx.Location = new System.Drawing.Point(541, 245);
            this.ProfileFullNameTxtBx.Name = "ProfileFullNameTxtBx";
            this.ProfileFullNameTxtBx.Size = new System.Drawing.Size(247, 22);
            this.ProfileFullNameTxtBx.TabIndex = 0;
            // 
            // ProfilePswdTxtBx
            // 
            this.ProfilePswdTxtBx.Location = new System.Drawing.Point(541, 292);
            this.ProfilePswdTxtBx.Name = "ProfilePswdTxtBx";
            this.ProfilePswdTxtBx.PasswordChar = '*';
            this.ProfilePswdTxtBx.Size = new System.Drawing.Size(247, 22);
            this.ProfilePswdTxtBx.TabIndex = 1;
            // 
            // ProfileUserRoleTxtBx
            // 
            this.ProfileUserRoleTxtBx.Location = new System.Drawing.Point(541, 420);
            this.ProfileUserRoleTxtBx.Name = "ProfileUserRoleTxtBx";
            this.ProfileUserRoleTxtBx.ReadOnly = true;
            this.ProfileUserRoleTxtBx.Size = new System.Drawing.Size(247, 22);
            this.ProfileUserRoleTxtBx.TabIndex = 2;
            // 
            // ProfileEmailTxtBx
            // 
            this.ProfileEmailTxtBx.Location = new System.Drawing.Point(541, 332);
            this.ProfileEmailTxtBx.Name = "ProfileEmailTxtBx";
            this.ProfileEmailTxtBx.Size = new System.Drawing.Size(247, 22);
            this.ProfileEmailTxtBx.TabIndex = 3;
            // 
            // ProfileUserNameTxtBx
            // 
            this.ProfileUserNameTxtBx.Location = new System.Drawing.Point(541, 375);
            this.ProfileUserNameTxtBx.Name = "ProfileUserNameTxtBx";
            this.ProfileUserNameTxtBx.Size = new System.Drawing.Size(247, 22);
            this.ProfileUserNameTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Role";
            // 
            // ProfileUpdateBtn
            // 
            this.ProfileUpdateBtn.Location = new System.Drawing.Point(541, 481);
            this.ProfileUpdateBtn.Name = "ProfileUpdateBtn";
            this.ProfileUpdateBtn.Size = new System.Drawing.Size(247, 33);
            this.ProfileUpdateBtn.TabIndex = 10;
            this.ProfileUpdateBtn.Text = "Update";
            this.ProfileUpdateBtn.UseVisualStyleBackColor = true;
            this.ProfileUpdateBtn.Click += new System.EventHandler(this.ProfileUpdateBtn_Click);
            // 
            // ProfileShowPasswordChkBx
            // 
            this.ProfileShowPasswordChkBx.AutoSize = true;
            this.ProfileShowPasswordChkBx.Location = new System.Drawing.Point(806, 294);
            this.ProfileShowPasswordChkBx.Name = "ProfileShowPasswordChkBx";
            this.ProfileShowPasswordChkBx.Size = new System.Drawing.Size(125, 20);
            this.ProfileShowPasswordChkBx.TabIndex = 11;
            this.ProfileShowPasswordChkBx.Text = "Show Password";
            this.ProfileShowPasswordChkBx.UseVisualStyleBackColor = true;
            this.ProfileShowPasswordChkBx.CheckedChanged += new System.EventHandler(this.ProfileShowPasswordChkBx_CheckedChanged);
            // 
            // ProfileResetBtn
            // 
            this.ProfileResetBtn.Location = new System.Drawing.Point(607, 520);
            this.ProfileResetBtn.Name = "ProfileResetBtn";
            this.ProfileResetBtn.Size = new System.Drawing.Size(116, 41);
            this.ProfileResetBtn.TabIndex = 12;
            this.ProfileResetBtn.Text = "Reset";
            this.ProfileResetBtn.UseVisualStyleBackColor = true;
            this.ProfileResetBtn.Click += new System.EventHandler(this.ProfileResetBtn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 602);
            this.Controls.Add(this.ProfileResetBtn);
            this.Controls.Add(this.ProfileShowPasswordChkBx);
            this.Controls.Add(this.ProfileUpdateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfileUserNameTxtBx);
            this.Controls.Add(this.ProfileEmailTxtBx);
            this.Controls.Add(this.ProfileUserRoleTxtBx);
            this.Controls.Add(this.ProfilePswdTxtBx);
            this.Controls.Add(this.ProfileFullNameTxtBx);
            this.MaximumSize = new System.Drawing.Size(1175, 649);
            this.MinimumSize = new System.Drawing.Size(1175, 649);
            this.Name = "Profile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProfileFullNameTxtBx;
        private System.Windows.Forms.TextBox ProfilePswdTxtBx;
        private System.Windows.Forms.TextBox ProfileUserRoleTxtBx;
        private System.Windows.Forms.TextBox ProfileEmailTxtBx;
        private System.Windows.Forms.TextBox ProfileUserNameTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ProfileUpdateBtn;
        private System.Windows.Forms.CheckBox ProfileShowPasswordChkBx;
        private System.Windows.Forms.Button ProfileResetBtn;
    }
}
using Order_Management_System___OODJ.models;
using Order_Management_System___OODJ.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Management_System___OODJ.Forms
{
    public partial class Profile : Form
    {
        private UserUtils userUtils = new UserUtils();
        private Utils utils = new Utils();
        public Profile()
        {
            InitializeComponent();
        }

        private void ProfileShowPasswordChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if(ProfileShowPasswordChkBx.Checked)
            {
                ProfilePswdTxtBx.PasswordChar = '\0';
            } else
            {
                ProfilePswdTxtBx.PasswordChar = '*';
            }
        }

        private void ProfileUpdateBtn_Click(object sender, EventArgs e)
        {
            if(ProfileFullNameTxtBx.Text != "")
            {
                if(ProfilePswdTxtBx.Text != "")
                {
                    if(ProfileEmailTxtBx.Text != "")
                    {
                        if(utils.isEmailValid(ProfileEmailTxtBx.Text))
                        {
                            if (ProfileUserNameTxtBx.Text != "")
                            {
                                Users UserID = userUtils.getCurrentLoggedUser(Variables.activeUsersFilePath, Variables.usersFilePath);
                                Users user = new Users();
                                user.Id = UserID.Id;
                                user.UserFullName = ProfileFullNameTxtBx.Text;
                                user.UserName = ProfileUserNameTxtBx.Text;
                                user.UserPassword = ProfilePswdTxtBx.Text;
                                user.UserEmail = ProfileEmailTxtBx.Text;
                                user.UserRole = ProfileUserRoleTxtBx.Text;
                                userUtils.updateProfile(Variables.usersFilePath, user);
                                MessageBox.Show("Success!", "Profile Updated Successfully");
                                populateFields();
                            } else
                            {
                                utils.ShowError("Error", "Enter User Name");
                            }
                        } else
                        {
                            utils.ShowError("Error", "Please Enter Valid Email");
                        }
                    } else
                    {
                        utils.ShowError("Error", "Enter Email");
                    }
                }
                else
                {
                    utils.ShowError("Error", "Enter Password");
                }
            } else
            {
                utils.ShowError("Error", "Enter full name");
            }
        }

        private void populateFields()
        {
            Users user = userUtils.getCurrentLoggedUser(Variables.activeUsersFilePath, Variables.usersFilePath);
            ProfileFullNameTxtBx.Text = user.UserFullName;
            ProfileEmailTxtBx.Text = user.UserEmail;
            ProfileUserRoleTxtBx.Text = user.UserRole;
            ProfileUserNameTxtBx.Text = user.UserName;
            ProfilePswdTxtBx.Text = user.UserPassword;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            populateFields();
        }

        private void ProfileResetBtn_Click(object sender, EventArgs e)
        {
            populateFields();
        }
    }
}

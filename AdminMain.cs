using Order_Management_System___OODJ.Design;
using Order_Management_System___OODJ.Forms;
using Order_Management_System___OODJ.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Management_System___OODJ
{
    public partial class AdminMain : Form
    {
        private Utils utils = new Utils();
        private string loggedUserFilePath = @"D:\Work\frreelanncefivr\Harpret assignments\OODJ\Order Management System - OODJ\db\logged_user.txt";
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public AdminMain()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            //if color is alreadyu selected, it will choose another color
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
                    AdminPanelTitleBar.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previoudBtn in AdminPanelMenu.Controls)
            {
                if(previoudBtn.GetType() == typeof(Button))
                {
                    previoudBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previoudBtn.ForeColor = Color.Gainsboro;
                    previoudBtn.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.AdminChildPanelDesktop.Controls.Add(childForm);
            this.AdminChildPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void AdminPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            utils.DeleteAllLines(loggedUserFilePath);
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void AdminProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(), sender);
            AdminPanelBarLbl.Text = "Admin Profile";
        }

        private void AdminAddProductBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Add_Product(), sender);
            AdminPanelBarLbl.Text = "Add Product";
        }

        private void AdminViewProductsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View_Products(), sender);
            AdminPanelBarLbl.Text = "View Products";
        }

        private void AdminEditProductBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Edit_Product(), sender);
            AdminPanelBarLbl.Text = "Edit Product";
        }

        private void AdminViewSearchOrderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View_Orders(), sender);
            AdminPanelBarLbl.Text = "View/Search Order";
        }

        private void AdminUpdateOrderStatusBtn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Update_Order_Status(), sender);
            AdminPanelBarLbl.Text = "Update Order Status";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AdminChildPanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

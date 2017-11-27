using Entities;
using RpgSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgSystem
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User user = userController.GetUser(txt_login.Text, txt_password.Text);
            if (user!=null) {
                Hide();
                
                Form frm_projectSelect = new frm_projectSelect(user, this);
                frm_projectSelect.Show();
            }
            else
            {
                MessageBox.Show("Account or password may be incorrect!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_create_account_Click(object sender, EventArgs e)
        {
            Form frm_createAccount = new frm_createUser();
            frm_createAccount.ShowDialog();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = "Administrador",
                Lastname = "1234",
                Login = "admin",
                Password = "admin",
                Projects = new List<Project>() { new Project() { Name = "As aventuras de lala"} }
            };
            UserController userController = new UserController();
            userController.Save(user);
        }

        private void frm_Login_Activated(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_password.Text = "";
        }
    }
}

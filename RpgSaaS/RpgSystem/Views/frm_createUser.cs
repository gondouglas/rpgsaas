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
    public partial class frm_createUser : Form
    {
        public frm_createUser()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_confirm.Text)
            {

                User user = new User()
                {
                    Name = txt_name.Text,
                    Lastname = txt_lastname.Text,
                    Login = txt_login.Text,
                    Password = txt_password.Text
                };
                try
                {
                    UserController userController = new UserController();
                    userController.Save(user);
                    MessageBox.Show("Account created with successfully!","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Hide();
                }
                catch (Exception exc) {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password is not equals confirm password!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

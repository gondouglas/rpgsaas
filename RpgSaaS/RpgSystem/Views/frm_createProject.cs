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

namespace RpgSystem.Views
{
    public partial class frm_createProject : Form
    {
        public User userLogged { get; set; }

        public frm_createProject(User userLogged)
        {
            InitializeComponent();
            this.userLogged = userLogged;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_description.Text))
            {
                MessageBox.Show("No field can be blank!");
            }
            else
            {
                UserController userController = new UserController();
                Project project = new Project()
                {
                    Name = txt_name.Text,
                    Description = txt_description.Text
                };
                userLogged.Projects.Add(project);
                userController.Update(userLogged);
                Hide();
            }
        }
    }
}

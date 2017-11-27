using Entities;
using RpgSystem.Controllers;
using RpgSystem.Views;
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
    public partial class frm_projectSelect : Form
    {
        public User UserLogged { get; set; }
        public frm_Login frm_login { get; set; }

        public frm_projectSelect(User user, frm_Login frm_login)
        {
            UserLogged = user;
            this.frm_login = frm_login;
            InitializeComponent();

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Hide();
            Form frm_main = new frm_mainScreen();
            frm_main.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_title.Text = list_projects.Text;
                lbl_description.Text = UserLogged.Projects.Find(x => x.Name.Equals(list_projects.Text)).Description;
            }
            catch (NullReferenceException exc)
            {

            }

        }

        private void frm_projectSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frm_projectSelect_Load(object sender, EventArgs e)
        {
            lbl_username.Text = UserLogged.Name;
            RefreshList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                UserController userController = new UserController();
                userController.GetUser(UserLogged.Login, UserLogged.Password).Projects.RemoveAt(list_projects.SelectedIndex);
                RefreshList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RefreshList()
        {
            list_projects.Items.Clear();
            lbl_title.Text = "";
            lbl_description.Text = "";
            foreach (Project project in UserLogged.Projects)
            {
                list_projects.Items.Add(project);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserLogged = null;
            frm_login.Show();
            Hide();
        }

        private void btn_createProject_Click(object sender, EventArgs e)
        {
            frm_createProject frm_CreateProject = new frm_createProject(UserLogged);
            frm_CreateProject.Show();
            RefreshList();
        }

        private void frm_projectSelect_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

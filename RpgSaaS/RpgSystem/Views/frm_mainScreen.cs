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
    public partial class frm_mainScreen : Form
    {
        public Project projectSelected { get; set; }
        public User userLogged { get; set; }
        public frm_projectSelect frm_ProjectSelect { get; set; }
        Hero hero;
        UserController userController = new UserController();


        public frm_mainScreen(Project project, User userLogged, frm_projectSelect frm_ProjectSelect)
        {
            projectSelected = project;
            this.userLogged = userLogged;
            hero = new Hero();
            this.frm_ProjectSelect = frm_ProjectSelect;
            InitializeComponent();
        }

        private void frm_mainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frm_mainScreen_Load(object sender, EventArgs e)
        {
            Text = projectSelected.Name;
            RefreshList();
        }

        private void list_characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < userLogged.Projects.Count; i++)
            {
                if (list_characters.SelectedIndex >= 0)
                {
                    if (userLogged.Projects[i].CreationDate.Equals(projectSelected.CreationDate))
                    {
                        hero = (Hero)userLogged.Projects[i].Characters[list_characters.SelectedIndex];
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            txt_name.Text = hero.Name;
            txt_hp.Text = hero.MaxHp.ToString();
            txt_mp.Text = hero.MaxMp.ToString();
            txt_sp.Text = hero.MaxSp.ToString();
            txt_level.Text = hero.Level.CurrentLevel.ToString();
            txt_base.Text = hero.Level.B.ToString();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            hero.Name = txt_name.Text;
            SaveUser();
            RefreshList();
        }

        private void txt_hp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hero.MaxHp = Convert.ToInt32(txt_hp.Text);
                SaveUser();
            }
            catch (Exception)
            {
            }
            RefreshList();
        }

        private void txt_mp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hero.MaxMp = Convert.ToInt32(txt_mp.Text);
                SaveUser();
            }
            catch (Exception)
            {
            }
            RefreshList();
        }

        private void txt_sp_TextChanged(object sender, EventArgs e)
        {

            try
            {
                hero.MaxSp = Convert.ToInt32(txt_sp.Text);
                SaveUser();
            }
            catch (Exception)
            {
            }
            RefreshList();
        }

        private void txt_level_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hero.Level.CurrentLevel = Convert.ToInt32(txt_level.Text);
                SaveUser();
            }
            catch (Exception)
            {
            }
            RefreshList();
        }

        private void txt_base_TextChanged(object sender, EventArgs e)
        {

            try
            {
                hero.Level.B = Convert.ToInt32(txt_base.Text);
                SaveUser();
            }
            catch (Exception)
            {
            }

            RefreshList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userLogged.Projects.Count; i++)
            {
                if (userLogged.Projects[i].CreationDate.Equals(projectSelected.CreationDate))
                {
                    userLogged.Projects[i].Characters.Add(new Hero() { Name = "- - -" });
                    break;
                }
            }
            SaveUser();
            RefreshList();
        }

        private void SaveUser()
        {
            for (int i = 0; i < projectSelected.Characters.Count; i++)
            {
                if (projectSelected.Characters[i].CreatedDate.Equals(hero.CreatedDate))
                {
                    projectSelected.Characters[i] = hero;
                    break;
                }
            }
            for (int i = 0; i < userLogged.Projects.Count; i++)
            {
                if (userLogged.Projects[i].CreationDate.Equals(projectSelected.CreationDate))
                {
                    userLogged.Projects[i] = projectSelected;
                    break;
                }
            }
            userController.Update(userLogged);
        }

        private void RefreshList()
        {
            list_characters.Items.Clear();
            foreach (Hero hero in userLogged.Projects.Find(x => x.Name.Equals(projectSelected.Name)).Characters)
            {
                list_characters.Items.Add(hero);
            }
        }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            userLogged = null;
            frm_ProjectSelect.Show();
            Hide();
        }


        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_control.SelectedIndex > 0)
            {
                MessageBox.Show("Coming Soon!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tab_control.SelectedIndex = 0;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userLogged.Projects.Count; i++)
            {
                if (list_characters.SelectedIndex >= 0)
                {
                    if (userLogged.Projects[i].CreationDate.Equals(projectSelected.CreationDate))
                    {
                        userLogged.Projects[i].Characters.RemoveAt(list_characters.SelectedIndex);
                        break;
                    }
                }
                else { break; }
            }
            SaveUser();
            RefreshList();
        }
    }

}

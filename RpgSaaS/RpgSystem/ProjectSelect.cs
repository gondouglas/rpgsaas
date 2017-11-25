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
        public frm_projectSelect()
        {
            InitializeComponent();
        }

        private void frm_projectSelect_Load(object sender, EventArgs e)
        {
            Form frm_login = new frm_Login();
            frm_login.ShowDialog();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Hide();
            Form frm_main = new frm_mainScreen();
            frm_main.Show();
        }
    }
}

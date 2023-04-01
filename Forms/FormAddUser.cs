using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormAddUser : Form
    {
        
        public FormAddUser()
        {
            InitializeComponent();
        }

        public FormAddUser(string username, string password, string permision)
        {
            Nametxt.Text = username;
            Passwordtxt.Text = password;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int roleid;
            string selectedRights = Isadmintxt.SelectedItem.ToString();
            if (Isadmintxt.ValueMember == "admin")
            {
                roleid = 10;
            }
            else
            {
                roleid = 11;
            }
            SqlRepository.RegisterUser(Nametxt.Text, Passwordtxt.Text, roleid);
            MessageBox.Show("uživatel přídán do databáze");
        }
    }
}

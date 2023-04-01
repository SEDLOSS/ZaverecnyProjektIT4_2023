using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormLogin : Form
    {
        public User LoggedUser { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }



        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            Loginbtn.Enabled = Nametxt.Text != string.Empty && Passwordtxt.Text != string.Empty;
        }



        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            User user = SqlRepository.CheckLogin(Nametxt.Text, Passwordtxt.Text);
            if (user == null)
            {
                MessageBox.Show("Špatné pøihlašovací údaje");
            }
            else
            {
                LoggedUser = user;
                Close();
            }
        }
    }
}

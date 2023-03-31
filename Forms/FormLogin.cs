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

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            var RegfistrationForm = new FormEmployeeAdd();
            RegfistrationForm.Show();


        }
        


        private void loginbutton_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}

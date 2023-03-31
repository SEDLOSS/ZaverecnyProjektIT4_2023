using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormEmployeeAdd : Form
    {

        private int id = -1;

        public FormEmployeeAdd()
        {
            InitializeComponent();
        }


        public FormEmployeeAdd(Employee employee)
        {
            id = employee.Id;
            InitializeComponent();
            Nametxt.Text = employee.FirstName;
            Name1txt.Text = employee.LastName;
            Birthtxt.Value = employee.BirthDate;
            Emailtxt.Text = employee.Email;
            Phonetxt.Text = employee.PhoneNumber;

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text != "" && Name1txt.Text != "" && Emailtxt.Text != "" && Phonetxt.Text != "")
            {
                Addbtn.Enabled = true;
            }
            else
            {
                Addbtn.Enabled = false;
            }
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddEmployee(new Employee(Nametxt.Text, Name1txt.Text, Birthtxt.Value, Emailtxt.Text, Phonetxt.Text));
            }
            else
            {
                SqlRepository.EditEmployee(id, new Employee(Nametxt.Text, Name1txt.Text, Birthtxt.Value, Emailtxt.Text, Phonetxt.Text));
            }

            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

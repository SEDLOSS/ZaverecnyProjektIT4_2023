using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormContractADD : Form
    {
        private int id = -1;
        public FormContractADD()
        {
            InitializeComponent();
        }

        public FormContractADD(Contract contract)
        {
            id = contract.ID;
            InitializeComponent();
            Customertxt.Text = contract.Customer;
            Desctriptiontxt.Text = contract.Description;
        }

        private void Customertxt_TextChanged(object sender, EventArgs e)
        {
            if (Customertxt.Text != "" && Desctriptiontxt.Text != "")
            {
                Addbtn.Enabled = true;
            }
            else
            {
                Addbtn.Enabled = false;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddContract(new Contract(Customertxt.Text, Desctriptiontxt.Text));
            }
            else
            {
                SqlRepository.EditContract(id, new Contract(Customertxt.Text, Desctriptiontxt.Text));
            }

            Close();
        }
    }
}

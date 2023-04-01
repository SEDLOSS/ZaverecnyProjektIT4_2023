using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormWorkTypeAdd : Form
    {
        private int id = -1;
        public FormWorkTypeAdd()
        {
            InitializeComponent();
        }

        public FormWorkTypeAdd(WorkType worktype)
        {
            id = worktype.ID;
            InitializeComponent();
            Nametxt.Text = worktype.Name;
            Descriptiontxt.Text = worktype.Description;
        }


        private void Descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddWorktype(new WorkType(Nametxt.Text, Descriptiontxt.Text));
            }
            else
            {
                SqlRepository.EditWorktype(id, new WorkType(Nametxt.Text, Descriptiontxt.Text));
            }

            Close();
        }
    }
}

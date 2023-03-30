using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    public partial class main : Form
    {

        List<Employee> employees = new List<Employee>();
        List<Contract> contracts = new List<Contract>();
        List<WorkType> worktypes = new List<WorkType>();

        public main()
        {
            InitializeComponent();
            employees = SqlRepository.EmployeeList();
            contracts = SqlRepository.ContractList();
            worktypes = SqlRepository.WorktypeList();
            updateemployee();
            updatecontracts();
            updateworktype();
        }

        private void updateemployee()
        {
            EmployeeListview.Items.Clear();
            foreach (Employee employee in SqlRepository.EmployeeList())
            {
                if (employee.FirstName.ToLower().Contains(EmployeeSearchtxt.Text.ToLower()) || (employee.LastName.ToLower().Contains(EmployeeSearchtxt.Text.ToLower())))
                    EmployeeListview.Items.Add(new ListViewItem(new string[] { employee.Id.ToString(), employee.FirstName, employee.LastName, employee.BirthDate.ToString(), employee.Email, employee.PhoneNumber }));
            }
        }

        private void updatecontracts()
        {
            ContractListview.Items.Clear();
            foreach (Contract contract in SqlRepository.ContractList())
            {
                if (contract.Customer.ToLower().Contains(ContractSearchtxt.Text.ToLower()))
                    ContractListview.Items.Add(new ListViewItem(new string[] { contract.Id.ToString(), contract.Customer, contract.Description }));
            }
        }

        private void updateworktype()
        {
            WorkListview.Items.Clear();
            foreach (WorkType worktype in SqlRepository.WorktypeList())
            {
                if (worktype.Name.ToLower().Contains(WorkSearchtxt.Text.ToLower()))
                    WorkListview.Items.Add(new ListViewItem(new string[] { worktype.ID.ToString(), worktype.Name, worktype.Description }));
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();
        }

        private void EmployeeListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDltbtn.Enabled = EmployeeListview.SelectedIndices.Count == 1;
            EmployeeEdtbtn.Enabled = EmployeeListview.SelectedIndices.Count == 1;
        }







        private void gatherUsersButton_Click_Click(object sender, EventArgs e)
         {
            
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace ZaverecnyProjektIT4_2023
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

            private void gatherUsersButton_Click_Click(object sender, EventArgs e)
        {
            var allUsers = SqlRepository.GatherAllUsers();

            // vymaž případné staré položky z ListView
            mainlistview.Items.Clear();

            // projdi všechny uživatele a přidej je do ListView
            foreach (var user in allUsers)
            {
                var item = new ListViewItem(user.ID.ToString());
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Roleid.ToString());
                
                mainlistview.Items.Add(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace e_learning_system
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            // disable the delete button until an item is selected
            delete_btn.Enabled = false;
            // get the entered name and search for it (make a SQL procedure to search and return results)
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Delete the record of the selected name
        }

        private void searchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable the delete button
        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            // approve the selected user
        }
    }
}

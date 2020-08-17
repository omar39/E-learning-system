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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            string query = "select user_id, phoneNumber from users where user_name='"+searchBar.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
          
            while (reader.Read())
            {
                string temp = "ID: " ;
                temp += reader.GetString(0);
                temp += " ";
                temp += "Phone number: ";
                temp+= reader.GetString(1);
              
                searchResultsList.Items.Add(temp);
            }
            reader.Close();
        }
    }
}

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
    public partial class Sign_in : Form
    {
        
        public Sign_in()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            registeration register_form = new registeration();
            register_form.Show();
            this.Hide();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            Program.conn = new MySqlConnection(Program.ordb);
            Program.conn.Open();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            string query = "select user_password from users where user_name='"+username_txt.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
           // MessageBox.Show("Login success");
            while (reader.Read())
            {
                if (reader.GetString(0) == password_txt.Text)
                    MessageBox.Show("Login success");
                else
                    MessageBox.Show("Login faild");
            }
            reader.Close();
        }
    }
}

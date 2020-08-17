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
    public partial class registeration : Form
    {
        public registeration()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            //check user occurence in database
            string userType = usersTypes.SelectedItem.ToString().ToLower();
            User user = UserFactory.make_user(userType, username_txt.Text, phoneNumber_txt.Text);

            string query = "select MAX(user_id) AS maxuser from users";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string user_id="-1";
         
            while (reader.Read())
            {
                    user_id = reader.GetString(0);
                int id = Int16.Parse(user_id);
                id++;
                user_id = id.ToString();
            }
            reader.Close();

            query = "insert into users VALUES('"+user_id+"','"+user.name+"','"+user.phoneNumber+"','"+password_txt.Text+"')";
            cmd = new MySqlCommand(query, Program.conn);
            reader = cmd.ExecuteReader();
            reader.Close();

            if (userType == "teacher")
            {
                query = "insert into teachers values('" + user_id + "','" + years_exp_tb.Text.ToString() + "','" + description_tb.Text.ToString() + "')";
            }
            else
            {
                query = "insert into students values('" + user_id + "')";
            }

            try
            {
                cmd = new MySqlCommand(query, Program.conn);
                reader = cmd.ExecuteReader();
                reader.Close();
                MessageBox.Show("Registeration completed");
                Sign_in f = new Sign_in();
                f.Show();
                this.Hide();
            }catch(Exception )
            {
                MessageBox.Show("please enter all data ");
            }

        }

        private void registeration_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usersTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersTypes.SelectedItem.ToString() == "Teacher")
            {
                des_lbl.Visible = true;
                description_tb.Visible = true;
                years_lbl.Visible = true;
                years_exp_tb.Visible = true;
            }
            else
            {
                des_lbl.Visible = false;
                description_tb.Visible = false;
                years_lbl.Visible = false;
                years_exp_tb.Visible = false;
            }
        }

        private void registeration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

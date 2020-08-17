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
        User newuser;

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
            string query = "select user_password, user_id, phoneNumber from users where user_name='"+username_txt.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string user_id="-1";
            string user_phone = "-1";
           // MessageBox.Show("Login success");
            while (reader.Read())
            {
                if (reader.GetString(0) == password_txt.Text)
                {
                    user_id = reader.GetString(1);
                    user_phone = reader.GetString(2);
                    MessageBox.Show("Login success");
                   // break;
                }
                else
                {
                    MessageBox.Show("Login faild");
                    reader.Close();
                    return;
                }
            }
            reader.Close();
           
            query = "select user_id from students where user_id='" + user_id + "'";
            cmd = new MySqlCommand(query, Program.conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                newuser = UserFactory.make_user("student", username_txt.Text, user_phone, Int16.Parse(user_id));
                MessageBox.Show("Student");
                StudentForm f = new StudentForm(Int16.Parse(user_id));
                reader.Close();
                f.Show();
                this.Hide();
                return;
            }
                reader.Close();

            query = "select user_id from sys_admin where user_id='" + user_id + "'";
            cmd = new MySqlCommand(query, Program.conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                newuser = UserFactory.make_user("admin", username_txt.Text, user_phone,Int16.Parse(user_id));
                MessageBox.Show("Admin");
                AdminForm f = new AdminForm();
                reader.Close();
                f.Show();
                this.Hide();
                return;
            }
                reader.Close();

            query = "select user_id from teachers where user_id='" + user_id + "'";
            cmd = new MySqlCommand(query, Program.conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                newuser = UserFactory.make_user("teacher", username_txt.Text, user_phone, Int16.Parse(user_id));
                MessageBox.Show("Teacher");
                TeacherForm f = new TeacherForm();
                reader.Close();
                f.Show();
                this.Hide();
                return;
            }
                reader.Close();

        }

        private void Sign_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class TeacherForm : Form
    {
        ITeacher _teacher;
        int id = 11;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            string query = "select MAX(post_id) AS maxpost from posts";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string user_id = "-1";

            while (reader.Read())
            {
                user_id = reader.GetString(0);
                int id = Int16.Parse(user_id);
                id++;
                user_id = id.ToString();
            }
            reader.Close();
            posts_view.Items.Add(postEditor.Text);
            query = "insert into posts " +
                            "values('"+user_id+"','" + id + "','" + postEditor.Text.ToString() + "','"+ classes_strip.SelectedItem.ToString() + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.ExecuteNonQuery();
            postEditor.Clear();
        }



        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT post_content FROM posts "+
                           "where teacher_id = '" + id.ToString() + "' "+
                           "and class_id = '"+classes_strip.SelectedItem.ToString() +"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            //commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        posts_view.Items.Add(reader.GetString(0));
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "2");
            }
        }


        private void join_btn_Click(object sender, EventArgs e)
        {
            string className = searchResultsList.SelectedItem.ToString();
            classes_strip.Items.Add(className);
            // add that teacher to that classroom database
        }

        private void searchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            join_btn.Enabled = true;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            // fetch from the database the class name
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT class_id FROM class_teachers where teacher_id = '" + id.ToString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            //commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        classes_strip.Items.Add(reader.GetString(0));
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "1");
            }
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

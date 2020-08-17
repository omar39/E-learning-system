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
                            "values('" + user_id + "','" + id + "','" + postEditor.Text.ToString() + "','" + classes_strip.SelectedItem.ToString() + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.ExecuteNonQuery();
            postEditor.Clear();
        }



        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT post_content FROM posts " +
                           "where teacher_id = '" + id.ToString() + "' " +
                           "and class_id = '" + classes_strip.SelectedItem.ToString() + "'";
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
            query = "select student_id from students_classes " +
                    "where class_id = '" + classes_strip.SelectedItem.ToString() + "'";
            commandDatabase = new MySqlCommand(query, Program.conn);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        students_cmb.Items.Add(reader.GetString(0));
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
                MessageBox.Show(ex.Message + "99");
            }
            query = "select subjectName from classrooms where class_id = '" + classes_strip.SelectedItem.ToString() + "'";
            commandDatabase = new MySqlCommand(query, Program.conn);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        subject_lbl.Text = reader.GetString(0);
                        subject_lbl.Visible = true;
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
                MessageBox.Show(ex.Message + "111");
            }

        }





        private void search_btn_Click(object sender, EventArgs e)
        {
            // fetch from the database the class name
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

            string query = "SELECT class_id FROM class_teachers where teacher_id = '" + id.ToString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
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
            query = "SELECT c.class_id " +
                    "FROM classrooms c";
            commandDatabase = new MySqlCommand(query, Program.conn);
            //commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        other_cmb.Items.Add(reader.GetString(0));
                    }


                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                for (int i = 0; i < classes_strip.Items.Count; i++)
                {
                    other_cmb.Items.Remove(classes_strip.Items[i]);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "7");
            }

        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into class_teachers " +
                "values('" + id + "','" + other_cmb.SelectedItem.ToString() + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            try
            {
                commandDatabase.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            classes_strip.Items.Add(other_cmb.SelectedItem);
            other_cmb.Items.Remove(other_cmb.SelectedItem);
        }

        private void students_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current_class = classes_strip.SelectedItem.ToString();
            string current_subject = subject_lbl.Text.ToString();
            string selected_student_id = students_cmb.SelectedItem.ToString();

            string query = "select grade from student_subjects " +
                    "where student_id = '" + selected_student_id + "' " +
                    "and subjectName = '" + current_subject + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        grade_box.Text = reader.GetString(0);
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

        private void update_grade_btn_Click(object sender, EventArgs e)
        {
            string new_grade = grade_box.Text.ToString();
            string query = "update student_subjects " +
                           "set grade = '" + new_grade + "'" +
                           "where student_id = '" + students_cmb.SelectedItem.ToString() + "' " +
                           "and subjectName = '" + subject_lbl.Text.ToString() + "' ";
            MySqlCommand command = new MySqlCommand(query, Program.conn);
            command.ExecuteNonQuery();
        }
    }
}

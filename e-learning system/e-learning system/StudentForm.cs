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
    public partial class StudentForm : Form
    {
        Student student = new Student();
        int id=0;
        
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT class_id FROM student_classes where student_id = '" + id.ToString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        classes_cmb.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = "SELECT class_id FROM student_classes where student_id != '" + id.ToString() + "'";
            commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        other_cmb.Items.Add(reader.GetString(0));
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = "SELECT subjectName,grade,subject_description"+
                    "FROM student_subjects c, subjects "+
                    "where student_id != '" + id.ToString() + "' and c.subjectName = subjects.subjectName";
            commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.set_subjects(reader.GetString(0), reader.GetDouble(1), reader.GetString(2));
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calc_gpa_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT grade,subjectName FROM student_subjects where student_id = '"+id.ToString()+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.set_grade(reader.GetString(1), reader.GetDouble(0));
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                gpa_tb.Text = Convert.ToString(student.calculateGrade());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void register_class_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into students_classes('student_id','class_id') "+
                            "values('" + id + "','" + other_cmb.SelectedItem.ToString() + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.ExecuteNonQuery();
            query = "SELECT subjectName,grade,subject_description" +
                    "FROM subjects, classrooms c " +
                    "where c.classid = '" + other_cmb.SelectedItem.ToString() + "' and c.subjectName = subjects.subjectName";
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.set_subjects(reader.GetString(0), reader.GetDouble(1), reader.GetString(2));
                        student.set_grade(reader.GetString(0), 0);
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            classes_cmb.Items.Add(other_cmb.SelectedItem);
            other_cmb.Items.Remove(other_cmb.SelectedItem);
        }

        private void choose_class_btn_Click(object sender, EventArgs e)
        {
            label_id.Text = classes_cmb.SelectedItem.ToString();
            label_id.Visible = true;
            string query = "SELECT subjectName " +
                           "FROM classrooms c " +
                           "where c.classid = '" + classes_cmb.SelectedItem.ToString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label_subject.Text = reader.GetString(0);
                        label_subject.Visible = true;
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = "SELECT post_content " +
                    "FROM posts a " +
                    "where a.classid = '" + classes_cmb.SelectedItem.ToString() + "'";
            commandDatabase = new MySqlCommand(query, Program.conn);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student_post_tb.Items.Add(reader.GetString(0));
                    }
                    reader.Close();

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

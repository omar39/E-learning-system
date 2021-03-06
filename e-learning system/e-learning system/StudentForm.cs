﻿using System;
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
        Student student;
        Classroom classroom;
        Subject subject;
        int _id=10;
        
        public StudentForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            student = new Student();
            string query = "SELECT class_id FROM students_classes where student_id = '" + _id.ToString() + "'";
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
                for(int i = 0;i< classes_cmb.Items.Count; i++)
                {
                    other_cmb.Items.Remove(classes_cmb.Items[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"2");
            }
            query = "SELECT c.subjectName,c.grade,c.subject_description FROM student_subjects AS a, subjects AS c where a.subjectName = c.subjectName and a.student_id <>'" + _id.ToString() + "'";
            commandDatabase = new MySqlCommand(query, Program.conn);
           // commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.set_subjects(reader.GetString(0), reader.GetDouble(1), reader.GetString(2));
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
                MessageBox.Show(ex.Message);
            }
        }

        private void calc_gpa_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT grade,subjectName FROM student_subjects where student_id = '"+_id.ToString()+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            double grade = 0;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.set_grade(reader.GetString(1), reader.GetDouble(0));
                        grade += reader.GetDouble(0);
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                gpa_tb.Text = Convert.ToString(grade);
                    reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void register_class_btn_Click(object sender, EventArgs e)
        {
            string new_subject = "";
            string query = "insert into students_classes "+
                            "values('" + _id + "','" + other_cmb.SelectedItem.ToString() + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            try
            {
                commandDatabase.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            query = "SELECT subjects.subjectName,subjects.grade,subjects.subject_description "+
                    "FROM subjects, classrooms c where c.class_id = '"+other_cmb.SelectedItem.ToString()+"' "+
                    "and c.subjectName = subjects.subjectName";
            commandDatabase = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        new_subject = reader.GetString(0);
/*                        student.set_subjects(reader.GetString(0), reader.GetDouble(1), reader.GetString(2));
                        student.set_grade(reader.GetString(0), 0);*/
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
                MessageBox.Show(ex.Message+"50");
            }
            classes_cmb.Items.Add(other_cmb.SelectedItem);
            other_cmb.Items.Remove(other_cmb.SelectedItem);

            int x = 0;
            query = "insert into student_subjects values ('" + _id + "','" + new_subject + "', 0)";
            commandDatabase = new MySqlCommand(query, Program.conn);

            commandDatabase.ExecuteNonQuery();




        }

        private void choose_class_btn_Click(object sender, EventArgs e)
        {
            label_id.Text = classes_cmb.SelectedItem.ToString();
            label_id.Visible = true;
            string query = "SELECT subjectName, grade " +
                           "FROM classrooms AS c " +
                           "where c.class_id = '" + classes_cmb.SelectedItem.ToString() + "'";
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
        
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                    reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            query = "SELECT post_content " +
                    "FROM posts AS a " +
                    "where a.class_id = '" + classes_cmb.SelectedItem.ToString() + "'";
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

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                    reader.Close();
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

        private void gpa_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void calc_gpa_btn_Click(object sender, EventArgs e)
        {
            int id=0;
            Student student = new Student();
            string query = "SELECT grade,subjectName FROM student_subjects where student_id = '"+id.ToString()+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                double grades = 0;
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        grades += reader.GetDouble(0);
                        student.

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

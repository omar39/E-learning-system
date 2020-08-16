using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_learning_system
{
    public partial class TeacherForm : Form
    {
        ITeacher _teacher;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            chatView.Items.Add(postEditor.Text);
            postEditor.Clear();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load class data of the current teacher
            
        }


        private void join_btn_Click(object sender, EventArgs e)
        {
            string className = searchResultsList.SelectedItem.ToString();
            toolStripComboBox1.Items.Add(className);
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
    }
}

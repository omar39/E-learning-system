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
    public partial class registeration : Form
    {
        public registeration()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            //check user occurence in database
            string userType = usersTypes.SelectedItem.ToString();
            User user = UserFactory.make_user(userType, fullName_txt.Text, phoneNumber_txt.Text);
        }
    }
}

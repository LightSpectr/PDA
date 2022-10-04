using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv1._3
{
    public partial class UserControl_Password2 : UserControl
    {
        public UserControl_Password2()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Password1.Text != textBox_Password2.Text)
            {
                MessageBox.Show("Passwords are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

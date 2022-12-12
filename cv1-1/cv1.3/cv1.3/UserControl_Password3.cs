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
    public partial class UserControl_Password3 : UserControl
    {
        public UserControl_Password3()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (checkBox_Show_Password.Checked)
            {
                MessageBox.Show("Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

        private void checkBox_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Password.Checked)
            {
                textBox_Password1.PasswordChar = '\0'; 
                textBox_Password2.Enabled = false;
            }
            else
            {
                textBox_Password1.PasswordChar = '*';

                textBox_Password2.Enabled = true;
            }
        }
    }
}

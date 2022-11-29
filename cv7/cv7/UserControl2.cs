using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cv5;


namespace cv7
{
    public partial class UserControl2 : FileIO { 
        public UserControl2()
        {
            InitializeComponent();
        }

        private void checkBox_copy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_copy.Checked)
            {
                textBox_FileTarget.Enabled = false;
                textBox_FileSource.Enabled = false;
                button_FileSource.Enabled = false;
                button_FileTarget.Enabled = false;

            }
            else
            {
                textBox_FileTarget.Enabled = true;
                textBox_FileSource.Enabled = true;
                button_FileSource.Enabled = true;
                button_FileTarget.Enabled = true;
            }
        }
    }
}

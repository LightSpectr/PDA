using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cv5;


namespace cv7
{
    public partial class FileIO2 : FileIO { 
        public FileIO2()
        {
            InitializeComponent();
        }

        private void checkBox_copy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_copy.Checked)
            {
                textBox_FileTarget.Enabled = false;
                
                button_FileTarget.Enabled = false;

            }
            else
            {
                textBox_FileTarget.Enabled = true;
               
                button_FileTarget.Enabled = true;
            }
        }

        public override string PathSave {
            get
            {   if(filePathS != null)
                {
                    if (checkBox_copy.Checked)
                    {
                        string file = Path.GetFileNameWithoutExtension(filePathS);
                       
                        return filePathS.Replace(file, file + "_copy");
                    }
                    else
                    {
                        return filePathS;
                    }
                }
                return "";
            }
                   
        }

    }
}

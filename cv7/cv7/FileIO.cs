using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv5
{
    partial class FileIO : UserControl
    {
        protected string filePathR;
        protected string filePathS;
        public FileIO()
        {
            filePathR = "";
            filePathS = "";
            InitializeComponent();
        }

        protected void button_FileSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "config soubory (*.ini)|*.ini|textové soubory (*.txt)|*.txt|csv soubory (*.csv)|*.csv|xml-soubory (*.xml)|*.xml|všechny soubory (*.*)|*.*";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathR = ofd.FileName;


                }
                else
                {
                    MessageBox.Show("Error opening file for read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (filePathR.Length > 0)
                textBox_FileSource.Text = filePathR;
            

        }

        protected void button_FileTarget_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.InitialDirectory = "c:\\";
                save.Filter = "config soubory (*.ini)|*.ini|textové soubory (*.txt)|*.txt|csv soubory (*.csv)|*.csv|xml-soubory (*.xml)|*.xml|všechny soubory (*.*)|*.*";
                save.RestoreDirectory = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathS = save.FileName;


                }
                else
                {
                    MessageBox.Show("Error opening file for write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (filePathS.Length > 0)
                textBox_FileTarget.Text = filePathS;
        }


        public virtual string PathRead { get { return filePathR; } }

        public virtual string PathSave { get { return filePathS; } }
    }
}

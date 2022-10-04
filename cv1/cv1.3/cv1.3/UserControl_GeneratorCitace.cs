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
    public partial class UserControl_GeneratorCitace : UserControl
    {
        public UserControl_GeneratorCitace()
        {
            InitializeComponent();
        }

        private void process_citation()
        {
            string citation = "";
            DateTime thisDay = DateTime.Today;

            if (textBox_LastName.Text.Length > 0)
            {
                citation += textBox_LastName.Text.ToUpper();

                if (textBox_FisrtName.Text.Length > 0)
                {
                    citation += ", " + textBox_FisrtName.Text;
                }

                citation += ".";
            }

            if(textBox_Name.Text.Length > 0)
            {
                citation += " " + textBox_Name.Text;
            }

            citation += " [online].";

            if(textBox_Year.Text.Length > 0)
            {
                citation += " " + textBox_Year.Text;
            }

            citation += String.Format(" [cit. {0}].", thisDay.ToString("yyyy-MM-dd"));


            if(textBox_URL.Text.Length > 0)
            {
                citation += " Dostupné z: " + textBox_URL.Text;
            }

            textBox_Citation.Text = citation;

        }

        private void textBox_FisrtName_TextChanged(object sender, EventArgs e)
        {
            process_citation();
        }

        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {
            process_citation();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            process_citation();
        }

        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {
            process_citation();
        }

        private void textBox_URL_TextChanged(object sender, EventArgs e)
        {
            process_citation();
        }
    }
}

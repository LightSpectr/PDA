using System.Collections;

namespace cv3._2
{
    public partial class Form1 : Form
    {
        ArrayList colors = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            listBox_Colors.DataSource = colors;
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_AddName.Text.Length == 0)
                {
                    throw new FormatException();
                }

                colors.Add(new Barva(textBox_AddName.Text, byte.Parse(textBox_AddRed.Text), byte.Parse(textBox_AddGreen.Text), byte.Parse(textBox_AddBlue.Text)));

                foreach (Control tb in groupBox_Add.Controls)
                {
                    if (tb is TextBox)
                    {
                        tb.Text = String.Empty;
                    }
                }
                

            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong format", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Color must be between 0-255", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
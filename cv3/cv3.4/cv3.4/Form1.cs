namespace cv3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioCheck()
        {
            if (radioButton_A.Checked == true)
            {
                textBox1.Text = radioButton_A.Text;
            }
            else if (radioButton_B.Checked == true)
            {
                textBox1.Text = radioButton_B.Text;

            }
            else if (radioButton_C.Checked == true)
            {
                textBox1.Text = radioButton_C.Text;

            }
        }

        private void radioButton_A_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck();
        }

        private void radioButton_B_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck();
        }

        private void radioButton_C_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
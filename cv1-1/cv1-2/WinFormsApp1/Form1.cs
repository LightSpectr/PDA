namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true ) 
            {
                
                label1.Text = checkBox1.Text = "checkBox1";
            }
            else
            {
                label1.Text = "label1";
            }

            if (checkBox2.Checked == true)
            {

                label2.Text = checkBox2.Text = "checkBox2";
            }
            else
            {
                label2.Text = "label2";
            }
            if (checkBox3.Checked == true)
            {

                label3.Text = checkBox3.Text = "checkBox3";
            }
            else
            {
                label3.Text = "label3";
            }
            if (checkBox4.Checked == true)
            {

                label4.Text = checkBox4.Text = "checkBox4";
            }
            else
            {
                label4.Text = "label4";
            }
            if (checkBox5.Checked == true)
            {

                label5.Text = checkBox5.Text = "checkBox5";
            }
            else
            {
                label5.Text = "label5";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
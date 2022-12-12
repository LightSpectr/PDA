namespace cv3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double income = 0;
            double tax = 0;
            double income_tax = 0;
            try
            {
                tax = Double.Parse(textBox_tax.Text);
                if (tax < 0 || tax > 100)
                {
                    MessageBox.Show("Tax must be 0-100 %", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                income = Double.Parse(textBox_income.Text);
                if (income < 0)
                {
                    MessageBox.Show("Income can't be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                income_tax = (tax * income) / 100.0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input string is not a sequence of digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number cannot fit in an Int32.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
                return;
            }
            string text = string.Format("Sazba daně: {0}%\n mzda (hrubá): {1}\n mzda (čistá): {2} ", textBox_tax.Text, textBox_income.Text, income - income_tax);

            MessageBox.Show(text, "Výpočet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
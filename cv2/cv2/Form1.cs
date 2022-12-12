namespace cv2
{
    public partial class Form1 : Form
    {
        Nadrz nad;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            try
            {
                nad = new Nadrz(UInt32.Parse(textBox_create.Text));

                textBox_number.Enabled = true;
                button_add.Enabled = true;
                button_sub.Enabled = true;

                textBox_create.Enabled = false;
                button_create.Enabled = false;

                label_state.Text = nad.ToString();

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
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

                nad.Pridat(UInt32.Parse(textBox_number.Text));
                label_state.Text = nad.ToString();
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
            catch (NadrzNelzeProvestOperaciException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            try
            {
               
                nad.Odebrat(UInt32.Parse(textBox_number.Text));
                label_state.Text = nad.ToString();
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
            catch (NadrzNelzeProvestOperaciException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
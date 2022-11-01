using System.Collections;
using System.Windows.Forms;

namespace cv3._2
{
    public partial class Form1 : Form
    {
        ArrayList colors;
        public Form1()
        {
            InitializeComponent();
            colors = new ArrayList();
            refresh_Listbox_Data();
          

        }

        private void refresh_Listbox_Data()
        {
            listBox_Colors.ClearSelected();
            
            listBox_Colors.DataSource = null;
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
                refresh_Listbox_Data();
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

        private void listBox_Colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Colors.SelectedItems.Count == 0)
            {
                textBox_ShowName.Text = String.Empty;
                textBox_ShowHex.Text = String.Empty;
                textBox_ShowInt.Text = String.Empty;
                colorBox.BackColor = Color.FromName("Control");
            }
            else
            {
                Barva barva = (Barva)listBox_Colors.SelectedItem;
                textBox_ShowName.Text = barva.Name;
                textBox_ShowHex.Text = barva.Hex;
                textBox_ShowInt.Text = barva.Intensity.ToString();
                colorBox.BackColor = ColorTranslator.FromHtml(barva.Hex);
            }
            

        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            if (listBox_Colors.SelectedIndex - 1 < 0)
            {
                listBox_Colors.SelectedIndex = listBox_Colors.Items.Count - 1;
            }
            else
            {
                listBox_Colors.SelectedIndex--;
            }
            
        }

        private void button_Down_Click(object sender, EventArgs e)
        {

            if (listBox_Colors.SelectedIndex + 1 > listBox_Colors.Items.Count - 1)
            {
                listBox_Colors.SelectedIndex = 0;
            }
            else
            {
                listBox_Colors.SelectedIndex++;
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            colors.RemoveAt(listBox_Colors.SelectedIndex);
            refresh_Listbox_Data();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (radioButton_Asc.Checked)
            {
                colors.Sort(new BarvaComparerAsc());
                refresh_Listbox_Data();

            }
            else if (radioButton_Des.Checked)
            {
                colors.Sort(new BarvaComparerDesc());
                refresh_Listbox_Data();
            }
        }
    }
}
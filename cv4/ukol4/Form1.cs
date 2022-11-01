using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace cv4
{
    public partial class Form1 : Form
    {
        
        public static BindingList<Nadrz> listos = new BindingList<Nadrz>();
        public Form1()
        {
            InitializeComponent();
            listos.Add(new Nadrz("N01",15));
            listos.Add(new Nadrz("N03", 25));
            listos.Add(new Nadrz("N04", 35));
            listos.Add(new Nadrz("N06", 45));
            listBox1.DataSource = listos;
            comboBox1.DataSource = listos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               
                    if (textBox1.Text.Length == 3 && (textBox1.Text[0].ToString() == "N" || textBox1.Text[0].ToString() == "n") && Char.IsDigit(textBox1.Text[1]) && Char.IsDigit(textBox1.Text[2]))
                    {                      
                        Nadrz n = new Nadrz(textBox1.Text.ToUpper(), Convert.ToUInt32(textBox2.Text));
                        if (!listos.Contains(n))
                        {
                            listos.Add(n);
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else MessageBox.Show("Toto ID již v nádrži existuje");
                    }
                    else MessageBox.Show("Špatný formát ID");               
            }
            catch (FormatException er1) { MessageBox.Show(er1.Message); }
            catch(OverflowException) { MessageBox.Show("Zadaná hodnota je mimo rozsah"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listos.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.SelectedItem = 0;           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listos[comboBox1.SelectedIndex].Add(Convert.ToUInt32(textBox3.Text));
                
                //REFRESH
                int index = comboBox1.SelectedIndex;
                List<Nadrz> listos2 = listos.ToList();
                listos.Clear();
                
                foreach (Nadrz x in listos2)
                {
                    listos.Add(x);
                }
                comboBox1.SelectedIndex = index;               
            }
            catch (NelzeVlozitDoNadrzeException er3) { MessageBox.Show(er3.Message); }
            catch (FormatException er4) { MessageBox.Show(er4.Message); }
            catch (OverflowException er5) { MessageBox.Show(er5.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listos[comboBox1.SelectedIndex].Remove(Convert.ToUInt32(textBox3.Text));

                //REFRESH
                int index = comboBox1.SelectedIndex;
                List<Nadrz> listos2 = listos.ToList();
                listos.Clear();
                foreach (Nadrz x in listos2)
                {
                    listos.Add(x);
                }
                comboBox1.SelectedIndex = index;              
            }
            catch (NelzeOdebratZNadrzeException er4) { MessageBox.Show(er4.Message); }
            catch (FormatException er4) { MessageBox.Show(er4.Message); }
            catch (OverflowException er5) { MessageBox.Show(er5.Message); }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButtonUp.Checked)
            {
                if (radioButtonID.Checked) raditUpId();
                else raditUpStav();
            }
            else
            {
                if (radioButtonID.Checked) raditDownId();
                else raditDownStav();
            }
        }
        
        public void raditUpId()
        {
            
            List<Nadrz> sortedBar = listos.OrderBy(o => o.Id).ToList();            
            listos.Clear();                       
            foreach (Nadrz x in sortedBar)
            {
                listos.Add(x);
            }
            
        }
        public void raditDownId()
        {           
            List<Nadrz> sortedBar = listos.OrderByDescending(o => o.Id).ToList();
            listos.Clear();
            foreach (Nadrz x in sortedBar)
            {
                listos.Add(x);
            }          
        }

        public void raditUpStav()
        {
            List<Nadrz> sortedBar = listos.OrderBy(o => o.Stav).ToList();
            listos.Clear();
            foreach (Nadrz x in sortedBar)
            {
                listos.Add(x);
            }
        }
        public void raditDownStav()
        {
            List<Nadrz> sortedBar = listos.OrderByDescending(o => o.Stav).ToList();
            listos.Clear();
            foreach (Nadrz x in sortedBar)
            {
                listos.Add(x);
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(listos[Convert.ToInt32(textBox4.Text)-1].ToString());
            }
            catch (FormatException er1) { MessageBox.Show(er1.Message); }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Číslo mimo rozsah"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 3 && (textBox4.Text[0].ToString() == "N" || textBox4.Text[0].ToString() == "n") && Char.IsDigit(textBox4.Text[1]) && Char.IsDigit(textBox4.Text[2]))
            {
                bool flag = false;
                foreach (Nadrz x in listos)
                {
                    if (x.Id == textBox4.Text.ToUpper())
                    {
                        MessageBox.Show(x.ToString());
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Nadrz s timto ID neexistuje");
                }

            }
            else MessageBox.Show("Spatny format ID");
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ukol4, Vytvořili T06.");
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonDown_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

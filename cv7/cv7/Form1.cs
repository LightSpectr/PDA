

namespace cv7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MojeSouboroveOperace.kopirujSoubor(fileiO21.PathRead, fileiO21.PathSave);
            MessageBox.Show("Done");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
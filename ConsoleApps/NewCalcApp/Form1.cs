using System.Data;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txt.Text = currentCalculation;
        }
        private void button_Equal_click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {
                txt.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = txt.Text;
            }
            catch (Exception ex)
            {
                txt.Text = "ERROR";
                currentCalculation = "";
            }
        }
        private void button_clear_click(object sender, EventArgs e)
        {
            txt.Text = "0";
            currentCalculation = "";
        }
        private void button_clearEntry_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txt.Text = currentCalculation;
        }
    }
}

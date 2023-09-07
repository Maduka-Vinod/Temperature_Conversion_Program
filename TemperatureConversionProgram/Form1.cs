namespace TemperatureConversionProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fahrenheit to Celcius")
            {
                double f = double.Parse(textBox1.Text);
                double c;

                c = (f - 32) * 5 / 9;

                textBox2.Text = c.ToString()+" C";
            }
            else if (comboBox1.Text == "Celcius to Fahrenheit")
            {
                double c = double.Parse(textBox1.Text);
                double f;

                f = (c * 9 / 5) + 32;

                textBox2.Text = f.ToString()+" F";

            }
            else
            {
                label5.Text = "Please Select The Option You Want To Convert!";
            }


        }
    }
}
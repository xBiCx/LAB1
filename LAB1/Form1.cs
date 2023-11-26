using System.Numerics;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "Hello World";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "5";
        }
        string number1 = string.Empty;
        private void button8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "0";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "-";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBoxInput.Text.Contains("."))
            {
                textBoxInput.Text += ".";
            }


        }
        string operation ;
        private void button15_Click(object sender, EventArgs e)
        {
            float output = 0;
            string number2 = textBoxInput.Text;
            float num1 = float.Parse(number1);
            float num2 = float.Parse(number2);
            if (operation == "+")
            {
                output = num1 + num2;
                textBoxInput.Text = output.ToString();
            }
            else if (operation == "-")
            {
                output = num1 - num2;
                textBoxInput.Text = output.ToString();
            }
            else if (operation == "*")
            {
                output = num1 * num2;
                textBoxInput.Text = output.ToString();
            }
            else if (operation == "/")
            {
                output = num1 / num2;
                textBoxInput.Text = output.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "/";
        }
    }
}

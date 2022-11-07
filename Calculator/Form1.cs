namespace Calculator
{
    public partial class Form1 : Form
    {

        string sign;
        double num1;
        double num2;

        bool startNewNumber = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberBt_Click("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBt_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberBt_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberBt_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberBt_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberBt_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberBt_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberBt_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberBt_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberBt_Click("9");
        }

        private void NumberBt_Click(string number)
        {
            if(startNewNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                startNewNumber = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void buttonSubstr_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Empty;
            switch (sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "Can not divided by 0";
                    }
                    else 
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);                      
                    } 
                    break;
            }
            sign = String.Empty;
            startNewNumber = true;
        }

        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text += sign;
            this.sign = sign;
            startNewNumber = true;
        }
    }
}
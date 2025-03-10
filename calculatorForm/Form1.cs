using CalculatorLibrary;

namespace calculatorForm
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBox1.Text += button.Text; // This should work if sender is really a button
            }
            else
            {
                MessageBox.Show($"Sender is not a button! It’s a {sender.GetType().Name}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nemeh_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                calculator.Add(number);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            calculator.resultClear();
        }

        private void hasah_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                calculator.Minus(number);
            }
        }

        private void tentsuu_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.Result.ToString();
        }

        private void hadgalah_Click(object sender, EventArgs e)
        {

        }
    }
}

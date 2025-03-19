using CalculatorLibrary;

namespace calculatorForm
{
    public partial class Form1 : Form
    {
        private Calculator calculator;    
        private string operationValue = "";
        private double firstNum = double.NaN;
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        // 1-9 and . button
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBox1.Text += button.Text;
            }
        }

        // +
        private void nemeh_Click(object sender, EventArgs e)
        {
            operationValue = "+";
            if (!double.IsNaN(firstNum))
            {
                calculator.Add(firstNum);
                textBox1.Clear();

            }
            else if (double.TryParse(textBox1.Text, out firstNum))
            {
                //calculator.Add(firstNum);
                textBox1.Clear();
            }
        }

        // -
        private void hasah_Click(object sender, EventArgs e)
        {
            operationValue = "-";
            if (textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            if (!double.IsNaN(firstNum))
            {
                calculator.Add(firstNum);
                textBox1.Clear();

            }
            else if (double.TryParse(textBox1.Text, out firstNum))
            {
                //calculator.Add(firstNum);
                textBox1.Clear();
            }
        }

        // =
        private void tentsuu_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double secondNum);
            if (operationValue == "+")
            {
                double num = firstNum + secondNum;
                calculator.Add(num);
            }
            else if (operationValue == "-")
            {
                var num = secondNum - firstNum;
                calculator.Add(num);
            }
            textBox1.Clear();
            textBox1.Text = calculator.Result.ToString();
            firstNum = calculator.Result;
            //operationValue = "";
            calculator.resultClear();
        }

        // C
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            calculator.resultClear();
        }

        // MS
        private void hadgalah_Click(object sender, EventArgs e)
        {
            //if (double.TryParse(textBox1.Text, out double number))
            //{
            //    listBox1.Items.Add(number);
            //}
            listBox1.Items.Add(textBox1.Text);
        }

        // MC
        private void memoryClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // M+
        private void memoryNemeh_Click(object sender, EventArgs e)
        {
            if (double.TryParse((string?)listBox1.SelectedItem, out double selectedNumber) && double.TryParse(textBox1.Text, out double inputNumber))
            {
                double result = selectedNumber + inputNumber;
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, result.ToString());
            }
        }

        // M-
        private void memoryHasah_Click(object sender, EventArgs e)
        {
            if (double.TryParse((string?)listBox1.SelectedItem, out double selectedNumber) && double.TryParse(textBox1.Text, out double inputNumber))
            {
                double result = selectedNumber - inputNumber;
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, result.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // listBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (double.TryParse(textBox1.Text, out double number))
            //{
            //    savedNumbers.Add(number); // Жагсаалтад нэмэх
            //    listBoxSavedNumbers.Items.Add(number); // ListBox-д нэмэх
            //    textBox1.Clear();
            //}
        }
    }
}

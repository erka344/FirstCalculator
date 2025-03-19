using CalculatorLibrary;
using CalculatorLibrary.memory;

namespace calculatorFrom2
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private string operStatus = "";
        private bool firstNum;
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
                input.Text += button.Text;
            }
        }

        // +
        private void nemeh_Click(object sender, EventArgs e)
        {
            double num = double.Parse(input.Text);
            if (operStatus == "")
            {
                calculator.Result = num;
                operStatus = "+";

                
            } else if (operStatus == "+")
            {
                calculator.Add(num);
                operStatus = "+";
            }
            else if (operStatus == "=")
            {
                ilerhiilel.Clear();
                //calculator.Add(num);
            }
            else
            {
                hasah_Click(sender, e);
            }

            ilerhiilel.Text += input.Text + "+";
            input.Clear();
        }

        // -
        private void hasah_Click(object sender, EventArgs e)
        {
            double num = double.Parse(input.Text);
            if (operStatus == "")
            {
                calculator.Add(num);
                operStatus = "-";
            }
            else if (operStatus == "-")
            {
                calculator.Minus(num);
                operStatus = "-";
            }
            else if (operStatus == "=")
            {
                ilerhiilel.Clear();
                //calculator.Minus(num);
            }
            else
            {
                nemeh_Click(sender, e);
            }

            ilerhiilel.Text += input.Text + "-";
            input.Clear();
        }

        // =
        private void tentsuu_Click(object sender, EventArgs e)
        {
            double num = double.Parse(input.Text);
            if (operStatus == "+")
            {
                calculator.Add(num);
            } else if (operStatus == "-")
            {
                calculator.Minus(num);
            }
            else
            {
                //ilerhiilel.Clear();
            }
            operStatus = "=";  
            ilerhiilel.Text += input.Text + "=";
            input.Clear();
            input.Text = calculator.Result.ToString();
        }

        // Clear
        private void clear_Click(object sender, EventArgs e)
        {
            input.Clear();
            operStatus = "";
            ilerhiilel.Clear();
            calculator.resultClear();
        }

        // MS
        private void hadgalah_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double num))
            {
                calculator.Result = num;
                calculator.Save();
                addmemoryItemInPanel(calculator.memory.items.Last());
            }
        }

        // jijig panel
        private void addmemoryItemInPanel(MemoryItem memoryItem)
        {
            Panel panelItem = new Panel
            {
                Size = new Size(280, 50),
                BackColor = Color.White,
            };
            Label label = new Label
            {
                Text = memoryItem.Value.ToString(),
                Size = new Size(100, 30),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
                Tag = memoryItem
            };

            // M+
            Button buttonMPlus = CreateButton("M+", () =>
            {
                if (double.TryParse(input.Text, out double N))
                {
                    memoryItem.Add(N);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            // M-
            Button buttonMMinus = CreateButton("M-", () =>
            {
                if (double.TryParse(input.Text, out double N))
                {
                    memoryItem.Minus(N);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            // MC
            Button buttonMClear = CreateButton("MC", () =>
            {
                if (double.TryParse(input.Text, out double N))
                {
                    history.Controls.Remove(panelItem);
                    calculator.memory.clearItem(memoryItem);
                    
                }
            });

            buttonMClear.Location = new Point(120, 10);
            buttonMPlus.Location = new Point(170, 10);
            buttonMMinus.Location = new Point(220, 10);

            panelItem.Controls.Add(label);
            panelItem.Controls.Add(buttonMClear);
            panelItem.Controls.Add(buttonMPlus);
            panelItem.Controls.Add(buttonMMinus);

            history.Controls.Add(panelItem);
            history.Controls.SetChildIndex(panelItem, 0);

            
        }


        
        private Button CreateButton(string text, Action onClick)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(40, 30),
                Visible = true
            };
            btn.Click += (s, e) => onClick();
            return btn;
        }

    }
}

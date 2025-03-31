using CalculatorLibrary;
using CalculatorLibrary.memory;

namespace calculatorFrom2
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private string operStatus = "";

        /// <summary>
        /// Form1-ийн анхны тохиргоо.
        /// </summary>
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        /// <summary>
        /// 1-9 болон "." товчлуур дарагдах үед тоог оруулна.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                input.Text += button.Text;
            }
        }

        /// <summary>
        /// "+" үйлдэл хийх үед дуудна.
        /// </summary>
        private void nemeh_Click(object sender, EventArgs e)
        {
            double num = double.Parse(input.Text);
            if (operStatus == "")
            {
                calculator.Result = num;
                operStatus = "+";
            }
            else if (operStatus == "+")
            {
                calculator.Add(num);
            }
            else if (operStatus == "=")
            {
                ilerhiilel.Clear();
            }
            else
            {
                hasah_Click(sender, e);
            }

            ilerhiilel.Text += input.Text + "+";
            input.Clear();
        }

        /// <summary>
        /// "-" үйлдэл хийх үед дуудна.
        /// </summary>
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
            }
            else if (operStatus == "=")
            {
                ilerhiilel.Clear();
            }
            else
            {
                nemeh_Click(sender, e);
            }

            ilerhiilel.Text += input.Text + "-";
            input.Clear();
        }

        /// <summary>
        /// "=" товчлуур дарагдах үед үр дүнг тооцоолж харуулна.
        /// </summary>
        private void tentsuu_Click(object sender, EventArgs e)
        {
            double num = double.Parse(input.Text);
            if (operStatus == "+")
            {
                calculator.Add(num);
            }
            else if (operStatus == "-")
            {
                calculator.Minus(num);
            }

            operStatus = "=";
            ilerhiilel.Text += input.Text + "=";
            input.Clear();
            input.Text = calculator.Result.ToString();
        }

        /// <summary>
        /// "C" товчлуур дарагдах үед тоон утгууд болон үйлдлийг устгана.
        /// </summary>
        private void clear_Click(object sender, EventArgs e)
        {
            input.Clear();
            operStatus = "";
            ilerhiilel.Clear();
            calculator.resultClear();
        }

        /// <summary>
        /// "MS" (Memory Save) товчлуур дарагдах үед одоогийн утгыг санах ойд хадгална.
        /// </summary>
        private void hadgalah_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double num))
            {
                calculator.Result = num;
                MemoryItem memo = calculator.Save();
                addmemoryItemInPanel(memo);
            }
        }

        /// <summary>
        /// Санах ойн утгыг харуулах жижиг панель үүсгэнэ.
        /// </summary>
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

            // "M+" товчлуур: хадгалсан утгыг нэмэх
            Button buttonMPlus = CreateButton("M+", () =>
            {
                if (double.TryParse(input.Text, out double N))
                {
                    memoryItem.Add(N);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            // "M-" товчлуур: хадгалсан утгыг хасах
            Button buttonMMinus = CreateButton("M-", () =>
            {
                if (double.TryParse(input.Text, out double N))
                {
                    memoryItem.Minus(N);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            // "MC" товчлуур: хадгалсан утгыг устгах
            Button buttonMClear = CreateButton("MC", () =>
            {
                history.Controls.Remove(panelItem);
                calculator.memory.clearItem(memoryItem);
                UpdatePanellocation();
            });

            buttonMClear.Location = new Point(110, 10);
            buttonMPlus.Location = new Point(160, 10);
            buttonMMinus.Location = new Point(210, 10);

            panelItem.Controls.Add(label);
            panelItem.Controls.Add(buttonMClear);
            panelItem.Controls.Add(buttonMPlus);
            panelItem.Controls.Add(buttonMMinus);

            history.Controls.Add(panelItem);
            history.Controls.SetChildIndex(panelItem, 0);

            UpdatePanellocation();
        }

        /// <summary>
        /// Товчлуур үүсгэх туслах функц.
        /// </summary>
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

        /// <summary>
        /// Санах ойн панелуудын байршлыг шинэчлэх.
        /// </summary>
        private void UpdatePanellocation()
        {
            int y = 10;
            foreach (Control control in history.Controls)
            {
                control.Location = new Point(10, y);
                y += control.Height + 5;
            }
        }
    }
}

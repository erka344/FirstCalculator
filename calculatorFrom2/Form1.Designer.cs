namespace calculatorFrom2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input = new TextBox();
            ilerhiilel = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            tentsuu = new Button();
            nemeh = new Button();
            hasah = new Button();
            clear = new Button();
            hadgalah = new Button();
            history = new Panel();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(12, 72);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(386, 49);
            input.TabIndex = 0;
            // 
            // ilerhiilel
            // 
            ilerhiilel.Location = new Point(12, 12);
            ilerhiilel.Multiline = true;
            ilerhiilel.Name = "ilerhiilel";
            ilerhiilel.Size = new Size(386, 44);
            ilerhiilel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(92, 69);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 142);
            button2.Name = "button2";
            button2.Size = new Size(92, 69);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(208, 142);
            button3.Name = "button3";
            button3.Size = new Size(92, 69);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 217);
            button4.Name = "button4";
            button4.Size = new Size(92, 69);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(110, 217);
            button5.Name = "button5";
            button5.Size = new Size(92, 69);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(208, 217);
            button6.Name = "button6";
            button6.Size = new Size(92, 69);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 292);
            button7.Name = "button7";
            button7.Size = new Size(92, 69);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(110, 292);
            button8.Name = "button8";
            button8.Size = new Size(92, 69);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(208, 292);
            button9.Name = "button9";
            button9.Size = new Size(92, 69);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(12, 367);
            button10.Name = "button10";
            button10.Size = new Size(92, 69);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button1_Click;
            // 
            // button11
            // 
            button11.Location = new Point(110, 367);
            button11.Name = "button11";
            button11.Size = new Size(92, 69);
            button11.TabIndex = 12;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button1_Click;
            // 
            // tentsuu
            // 
            tentsuu.Location = new Point(208, 367);
            tentsuu.Name = "tentsuu";
            tentsuu.Size = new Size(92, 69);
            tentsuu.TabIndex = 13;
            tentsuu.Text = "=";
            tentsuu.UseVisualStyleBackColor = true;
            tentsuu.Click += tentsuu_Click;
            // 
            // nemeh
            // 
            nemeh.Location = new Point(306, 142);
            nemeh.Name = "nemeh";
            nemeh.Size = new Size(92, 69);
            nemeh.TabIndex = 14;
            nemeh.Text = "+";
            nemeh.UseVisualStyleBackColor = true;
            nemeh.Click += nemeh_Click;
            // 
            // hasah
            // 
            hasah.Location = new Point(306, 217);
            hasah.Name = "hasah";
            hasah.Size = new Size(92, 69);
            hasah.TabIndex = 15;
            hasah.Text = "-";
            hasah.UseVisualStyleBackColor = true;
            hasah.Click += hasah_Click;
            // 
            // clear
            // 
            clear.Location = new Point(306, 292);
            clear.Name = "clear";
            clear.Size = new Size(92, 69);
            clear.TabIndex = 16;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // hadgalah
            // 
            hadgalah.Location = new Point(306, 367);
            hadgalah.Name = "hadgalah";
            hadgalah.Size = new Size(92, 69);
            hadgalah.TabIndex = 17;
            hadgalah.Text = "MS";
            hadgalah.UseVisualStyleBackColor = true;
            hadgalah.Click += hadgalah_Click;
            // 
            // history
            // 
            history.Location = new Point(412, 12);
            history.Name = "history";
            history.Size = new Size(263, 420);
            history.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 462);
            Controls.Add(history);
            Controls.Add(hadgalah);
            Controls.Add(clear);
            Controls.Add(hasah);
            Controls.Add(nemeh);
            Controls.Add(tentsuu);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ilerhiilel);
            Controls.Add(input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private TextBox ilerhiilel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button tentsuu;
        private Button nemeh;
        private Button hasah;
        private Button clear;
        private Button hadgalah;
        private Panel history;
    }
}

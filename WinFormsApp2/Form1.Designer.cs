namespace WinFormsApp2
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
            resultLabel = new RichTextBox();
            button1 = new Button();
            numberNumericUpDown = new NumericUpDown();
            sumTypeCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numberNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(262, 165);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(259, 132);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "";
            resultLabel.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(346, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ответ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numberNumericUpDown
            // 
            numberNumericUpDown.Location = new Point(308, 73);
            numberNumericUpDown.Name = "numberNumericUpDown";
            numberNumericUpDown.Size = new Size(167, 27);
            numberNumericUpDown.TabIndex = 4;
            // 
            // sumTypeCheckBox
            // 
            sumTypeCheckBox.AutoSize = true;
            sumTypeCheckBox.Location = new Point(339, 121);
            sumTypeCheckBox.Name = "sumTypeCheckBox";
            sumTypeCheckBox.Size = new Size(117, 24);
            sumTypeCheckBox.TabIndex = 5;
            sumTypeCheckBox.Text = "По формуле";
            sumTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sumTypeCheckBox);
            Controls.Add(numberNumericUpDown);
            Controls.Add(button1);
            Controls.Add(resultLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numberNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox resultLabel;
        private Button button1;
        private NumericUpDown numberNumericUpDown;
        private CheckBox sumTypeCheckBox;
    }
}

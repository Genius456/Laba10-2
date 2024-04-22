namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sumTypeCheckBox.Checked) 
            {
                int n = (int)numberNumericUpDown.Value;
                int sum = n * (n + 1) / 2;
                resultLabel.Text = "—ÛÏÏ‡: " + sum;
            }
            else 
            {
                int n = (int)numberNumericUpDown.Value;
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                resultLabel.Text = "—ÛÏÏ‡: " + sum;
            }
        }

        private void sumTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}


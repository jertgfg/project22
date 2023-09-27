namespace WinFormsApp1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                decimal income = decimal.Parse(textBox1.Text);
                decimal taxOwed = 0;

                if (income >= 0 && income <= 9225)
                {
                    taxOwed = income * 0.1m;
                }
                else if (income > 9225 && income <= 37450)
                {
                    taxOwed = 922.5m + (income - 9225) * 0.15m;
                }
                // Add more conditions for the remaining tax brackets...

                textBox2.Text = taxOwed.ToString("C");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

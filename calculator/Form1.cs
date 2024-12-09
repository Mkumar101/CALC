namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String total = "";
        int n1, n2;
        char option;
        int result;
        private void btn2_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn2.Text;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn1.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = '+';
            n1 = int.Parse(screen.Text);
            screen.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = '-';
            n1 = int.Parse(screen.Text);
            screen.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = '*';
            n1 = int.Parse(screen.Text);
            screen.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = '/';
            n1 = int.Parse(screen.Text);
            screen.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(screen.Text);
            switch (option)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
            }
            screen.Text = result.ToString();
        }
    }
}

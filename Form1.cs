using System.Text.RegularExpressions;

namespace valid_email_address_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex_v = new Regex(@"[^@\s]+@[^@\$]+\.[^@\s]+$");
            bool isvalid_v = regex_v.IsMatch(this.textBox1.Text);
            if (isvalid_v)
            {
                this.textBox2.Text = " This is a valid email";
            }
            else
            {
                this.textBox2.Text = " this is an invalid email";
            }
        }
    }
}
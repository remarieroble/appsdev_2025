namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnameValue = textBox1.Text;
            string lnameValue = textBox2.Text;
            MessageBox.Show($"Hello There! {fnameValue} {lnameValue}!", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Get the textBox1 Text and Add to the listBox1
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listbox.Items.Contains(textBox1.Text))
            {

                listbox.Items.Add(textBox1.Text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                // Remove the selected item
                listbox.Items.Remove(listbox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
    }
}

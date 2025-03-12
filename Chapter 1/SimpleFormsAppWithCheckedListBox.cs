namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            String[] movie = { "The God father", "Minions", "Wrong Turn", "Chupacabra" };
            checkedListBoxMovies.Items.AddRange(movie);

            checkedListBoxMovies.CheckOnClick = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxMovies.CheckedItems)
            {
                bool isSelected = checkedListBoxMovies.GetItemChecked(checkedListBoxMovies.Items.IndexOf(item));
                if (!listBoxSelectedMovies.Items.Contains(item))
                {
                    listBoxSelectedMovies.Items.Add(item);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedMovies.SelectedIndex != -1)
            {
                listBoxSelectedMovies.Items.RemoveAt(listBoxSelectedMovies.SelectedIndex);
            }
        }
private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listBoxSelectedMovies.Items.Clear();
        }
    }
}
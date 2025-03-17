namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foods = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox1.Items.AddRange(foods);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodsList = { "Adobo", "Tortang Talong", "Pancit", "Kare-Kare", "Sisig" };
            string[] japaneseFoodList = { "Shashimi", "Tonakatsu", "Takoyaki", "Bento", "Mochi" };
            string[] chineseFoodList = { "Mapo Tafu", "Spring Rolls", "Mapo Dafu", "Sticky Rice" };
            string[] koreanFoodList = { "Kimchi", "Mandu", "Bossam", "Banchan", "Gimbap" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoFoodsList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(japaneseFoodList);
            }
            if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseFoodList);
            }
            if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(koreanFoodList);
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Store;

namespace DVGB07_MediaStore
{
    public partial class AddBookForm : Form
    {
        internal Book NewBook { get; private set; }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(priceText.Text) || string.IsNullOrEmpty(stockText.Text))
                {
                    MessageBox.Show("All * fields are mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int pid = CSVHandler.GeneratePID();
                int price = int.Parse(priceText.Text);
                int stock = int.Parse(stockText.Text);
                string name = nameText.Text;
                string author = authorText.Text;
                string genre = genreText.Text;
                string format = formatText.Text;
                string language = languageText.Text;

                NewBook = new Book(pid, name, price, stock, author, genre, format, language);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

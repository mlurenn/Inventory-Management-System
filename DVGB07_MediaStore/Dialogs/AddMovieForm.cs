using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Store;

namespace DVGB07_MediaStore
{
    public partial class AddMovieForm : Form
    {
        internal Movie NewMovie { get; private set; }

        public AddMovieForm()
        {
            InitializeComponent();
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
                if (string.IsNullOrWhiteSpace(nameText.Text) ||
                    string.IsNullOrWhiteSpace(priceText.Text) ||
                    string.IsNullOrWhiteSpace(stockText.Text))
                {
                    MessageBox.Show("All fields marked with * are mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int length;
                int pid = CSVHandler.GeneratePID();
                int price = int.Parse(priceText.Text);
                int stock = int.Parse(stockText.Text);
                string name = nameText.Text;
                string genre = genreText.Text;
                string format = formatText.Text;
                if (string.IsNullOrWhiteSpace(lengthText.Text))
                    length = 0;
                else
                    length = int.Parse(lengthText.Text);

                NewMovie = new Movie(pid, name, price, stock, genre, format, length);
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

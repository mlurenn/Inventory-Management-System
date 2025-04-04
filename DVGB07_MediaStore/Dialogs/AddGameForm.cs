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
    public partial class AddGameForm : Form
    {
        internal Game NewGame { get; private set; }

        public AddGameForm()
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
                if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(priceText.Text) || string.IsNullOrEmpty(stockText.Text))
                {
                    MessageBox.Show("All * fields are mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int pid = CSVHandler.GeneratePID();
                int price = int.Parse(priceText.Text);
                if (!CheckPositive(price)) return;
                int stock = int.Parse(stockText.Text);
                if (!CheckPositive(stock)) return;
                string name = nameText.Text;
                string genre = genreText.Text;
                string platform = platformText.Text;

                NewGame = new Game(pid, name, price, stock, genre, platform);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckPositive(int value)
        {
            if (value < 0)
            {
                MessageBox.Show("Numbers cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

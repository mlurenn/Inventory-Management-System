using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_MediaStore.Dialogs
{
    public partial class AmountForm : Form
    {
        public int Amount { get; set; }

        public AmountForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(amountTextBox.Text,out int amount) && amount > 0)
            {
                Amount = amount;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Amount is not valid.");
            }
        }
    }
}

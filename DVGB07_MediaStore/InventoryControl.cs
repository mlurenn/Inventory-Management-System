using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVGB07_MediaStore;
using DVGB07_MediaStore.Dialogs;

namespace Media_Store
{
    public partial class InventoryControl : UserControl
    {   
        BindingSource booksSource;
        BindingSource gamesSource;
        BindingSource moviesSource;
        private List<Product> inventoryProducts;

        public InventoryControl(BindingSource booksSource, BindingSource gamesSource, BindingSource moviesSource)
        {
            InitializeComponent();
            this.booksSource = booksSource;
            booksDataGrid.DataSource = booksSource;
            this.gamesSource = gamesSource;
            gamesDataGrid.DataSource = gamesSource;
            this.moviesSource = moviesSource;
            moviesDataGrid.DataSource = moviesSource;

            inventoryProducts = new List<Product>();
            LoadProducts();
        }

        public void LoadProducts()
        {
            ClearGrids();

            List<Product> csvList = CSVHandler.LoadProducts();
            inventoryProducts.Clear();
            inventoryProducts.AddRange(csvList);

            booksSource.DataSource = inventoryProducts.OfType<Book>().ToList();
            gamesSource.DataSource = inventoryProducts.OfType<Game>().ToList();
            moviesSource.DataSource = inventoryProducts.OfType<Movie>().ToList();

            booksDataGrid.DataSource = booksSource;
            gamesDataGrid.DataSource = gamesSource;
            moviesDataGrid.DataSource = moviesSource;

            HandleColumns();
        }

        private void ClearGrids()
        {
            booksDataGrid.DataSource = null;
            gamesDataGrid.DataSource = null;
            moviesDataGrid.DataSource = null;
        }

        private void HandleColumns()
        {
            booksDataGrid.Columns["PID"].DisplayIndex = 0;
            booksDataGrid.Columns["Name"].DisplayIndex = 1;

            gamesDataGrid.Columns["PID"].DisplayIndex = 0;
            gamesDataGrid.Columns["Name"].DisplayIndex = 1;

            moviesDataGrid.Columns["PID"].DisplayIndex = 0;
            moviesDataGrid.Columns["Name"].DisplayIndex = 1;

            if (gamesDataGrid.Columns.Contains("Genre") && AllValuesEmpty(gamesDataGrid, "Genre"))
                gamesDataGrid.Columns["Genre"].Visible = false;
            if (moviesDataGrid.Columns.Contains("Genre") && AllValuesEmpty(moviesDataGrid, "Genre"))
                moviesDataGrid.Columns["Genre"].Visible = false;
        }

        private bool AllValuesEmpty(DataGridView dataGrid, string columnName)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
                if (row.Cells[columnName].Value != null && !string.IsNullOrWhiteSpace(row.Cells[columnName].Value.ToString()))
                    return false;

            return true;
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm())
            {
                addBookForm.StartPosition = FormStartPosition.CenterParent;

                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    Book newBook = addBookForm.NewBook;

                    if (newBook != null)
                    {
                        if (AddProduct(newBook))
                        {
                            MessageBox.Show("Book added to inventory");
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Could not add book to inventory");
                        }
                    }
                }
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            using (AddMovieForm addMovieForm = new AddMovieForm())
            {
                addMovieForm.StartPosition = FormStartPosition.CenterParent;

                if (addMovieForm.ShowDialog() == DialogResult.OK)
                {
                    Movie newMovie = addMovieForm.NewMovie;

                    if (newMovie != null)
                    {
                        if (AddProduct(newMovie))
                        {
                            MessageBox.Show("Movie added to inventory");
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Could not add movie to inventory");
                        }
                    }
                }
            }
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            using (AddGameForm addGameForm = new AddGameForm())
            {
                addGameForm.StartPosition = FormStartPosition.CenterParent;

                if (addGameForm.ShowDialog() == DialogResult.OK)
                {
                    Game newGame = addGameForm.NewGame;

                    if (newGame != null)
                    {
                        if (AddProduct(newGame))
                        {
                            MessageBox.Show("Game added to inventory");
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Could not add game to inventory");
                        }
                    }
                }
            }
        }

        private bool AddProduct(Product product)
        {
            if (inventoryProducts.Any(p => p.PID == product.PID))
            {
                Console.WriteLine("Ett produkt-ID med samma nummer finns redan.");
                return false;
            }
            inventoryProducts.Add(product);
            CSVHandler.SaveProducts(inventoryProducts);
            Console.WriteLine($"Produkt {product.Name} lagd till i lager.");
            return true;
        }

        private DataGridView GetDataGridView()
        {
            DataGridView selectedGrid = null;
            if (booksDataGrid.SelectedRows.Count > 0)
                selectedGrid = booksDataGrid;
            if (gamesDataGrid.SelectedRows.Count > 0)
                selectedGrid = gamesDataGrid;
            if (moviesDataGrid.SelectedRows.Count > 0)
                selectedGrid = moviesDataGrid;
            return selectedGrid;
        }
        private void reduceStockButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedProduct(GetDataGridView(), true);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedProduct(GetDataGridView(), false);
        }
        private void RemoveSelectedProduct(DataGridView dataGrid, bool reduce)
        {
            if (dataGrid == null || dataGrid.CurrentRow == null)
                return;

            int selectedPID = (int)dataGrid.CurrentRow.Cells["PID"].Value;
            Product product = inventoryProducts.FirstOrDefault(p => p.PID == selectedPID);
            if (product != null)
            {
                if (reduce)
                {
                    AmountForm dialog = new AmountForm();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int amount = dialog.Amount;
                        RemoveAmountOfProduct(product, amount);
                    }
                }
                else
                {
                    if (product.Stock != 0)
                    {
                        DialogResult dialog = MessageBox.Show(
                            "Are you sure you want to remove this product?",
                            "Confirm Removal",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            inventoryProducts.Remove(product);
                        }
                    }
                    else
                    {
                        inventoryProducts.Remove(product);
                    }
                }

                CSVHandler.SaveProducts(inventoryProducts);
                LoadProducts();
            }
        }

        private void RemoveAmountOfProduct(Product product, int amount)
        {
            product.Stock = product.Stock - amount;
            if (product.Stock < 0)
                product.Stock = 0;
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DeselectOtherGrids(sender);
        }

        private void DeselectOtherGrids(object sender)
        {
            var s = (DataGridView)sender;
            if (s.SelectedRows.Count > 0)
            {
                var otherDataGrids = this.Controls.OfType<DataGridView>().Except(new[] { s });
                foreach (var dgv in otherDataGrids)
                {
                    dgv.ClearSelection();
                }
            }
        }

        private void orderProductButton_Click(object sender, EventArgs e)
        {
            OrderProduct();
        }

        private void OrderProduct()
        {
            DataGridView selectedDataGrid = GetDataGridView();
            
            int selectedPID = (int)selectedDataGrid.CurrentRow.Cells["PID"].Value;
            Product product = inventoryProducts.FirstOrDefault(p => p.PID == selectedPID);
            if (product != null)
            {
                AmountForm dialog = new AmountForm();
                if (dialog.ShowDialog() == DialogResult.OK)
                    product.Stock += dialog.Amount;

                CSVHandler.SaveProducts(inventoryProducts);
                LoadProducts();
            }
        }
    }
}
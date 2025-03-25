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

namespace Media_Store
{
    public partial class InventoryControl : UserControl
    {
        private static string BOOK = "Book";
        private static string GAME = "Game";
        private static string MOVIE = "Movie";
        
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

        private void LoadProducts()
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
                    Book newBook = addBookForm.NewBook; // Hämta boken från formuläret

                    if (newBook != null)
                    {
                        InventoryManager inventoryManager = new InventoryManager();

                        if (inventoryManager.AddProduct(newBook))
                        {
                            MessageBox.Show("Book added to inventory");
                            LoadProducts(); // Uppdatera produktlistan
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
                        InventoryManager inventoryManager = new InventoryManager();

                        if (inventoryManager.AddProduct(newMovie))
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
                        InventoryManager inventoryManager = new InventoryManager();

                        if (inventoryManager.AddProduct(newGame))
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
    }
}
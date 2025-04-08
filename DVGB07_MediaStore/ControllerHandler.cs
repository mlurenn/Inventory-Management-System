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
    public partial class ControllerHandler : UserControl
    {
        private BindingSource booksSource;
        private BindingSource gamesSource;
        private BindingSource moviesSource;
        private List<Product> inventoryProducts;

        private DataGridView booksDataGrid;
        private DataGridView gamesDataGrid;
        private DataGridView moviesDataGrid;

        public ControllerHandler()
        {
            InitializeComponent();
            this.booksSource = booksSource;
            booksDataGrid.DataSource = booksSource;
            this.gamesSource = gamesSource;
            gamesDataGrid.DataSource = gamesSource;
            this.moviesSource = moviesSource;
            moviesDataGrid.DataSource = moviesSource;

            inventoryProducts = new List<Product>();
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
    }
}

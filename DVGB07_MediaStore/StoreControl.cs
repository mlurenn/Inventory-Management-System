﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVGB07_MediaStore.Dialogs;
using Media_Store;

namespace DVGB07_MediaStore
{
    public partial class StoreControl : UserControl
    {

        BindingSource booksSource;
        BindingSource gamesSource;
        BindingSource moviesSource;
        BindingSource cartSource;
        private List<Product> inventoryProducts;
        private Cart cart;

        public StoreControl(BindingSource booksSource, BindingSource gamesSource, BindingSource moviesSource, BindingSource cartSource)
        {
            InitializeComponent();

            this.booksSource = booksSource;
            booksDataGrid.DataSource = booksSource;

            this.gamesSource = gamesSource;
            gamesDataGrid.DataSource = gamesSource;

            this.moviesSource = moviesSource;
            moviesDataGrid.DataSource = moviesSource;

            this.cartSource = cartSource;
            cartDataGrid.DataSource = cartSource;
            if (cartDataGrid.Columns["Stock"] != null)
            {
                cartDataGrid.Columns["Stock"].HeaderText = "Quantity";
            }

            cart = new Cart();
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

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DeselectOtherGrids(sender);
        }


        private void DeselectOtherGrids(object sender)
        {
            var selectedGrid = (DataGridView)sender;
            if (selectedGrid.SelectedRows.Count > 0)
            {
                foreach (var dgv in new[] { booksDataGrid, gamesDataGrid, moviesDataGrid })
                {
                    if (dgv != selectedGrid)
                    {
                        dgv.ClearSelection();
                    }
                }
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            DataGridView selectedGrid = GetDataGridView();
            if (selectedGrid == null || selectedGrid.CurrentRow == null)
                return;

            int selectedPID = (int)selectedGrid.CurrentRow.Cells["PID"].Value;
            Product product = inventoryProducts.FirstOrDefault(p => p.PID == selectedPID);

            if (product != null)
            {
                if (product.Stock > cart.GetQuantityInCart(selectedPID))
                {
                    cart.AddToCart(product);
                    cartSource.DataSource = cart.GetCart();
                    cartSource.ResetBindings(false);
                    UpdatePrice();
                }
            }
        }


        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartDataGrid.SelectedRows.Count == 0 || cartSource == null)
                return;

            int selectedPID = (int)cartDataGrid.CurrentRow.Cells["PID"].Value;
            cart.RemoveFromCart(selectedPID);

            cartSource.DataSource = cart.GetCart();
            cartSource.ResetBindings(false);
            UpdatePrice();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            foreach (var cartItem in cart.GetCart())
            {
                Product inventoryProduct = inventoryProducts.FirstOrDefault(p => p.PID == cartItem.PID);
                if (inventoryProduct != null)
                {
                    inventoryProduct.Stock -= cartItem.Stock;
                }
            }

            CSVHandler.SaveProducts(inventoryProducts);
            LoadProducts();

            cart.EmptyCart();
            cartSource.DataSource = cart.GetCart();
            cartSource.ResetBindings(false);
            UpdatePrice();
            MessageBox.Show("Purchase complete!");
        }
        
        private void UpdatePrice()
        {
            int totalPrice = cart.GetTotalPrice();
            priceLabel.Text = $"Total Price: {totalPrice.ToString()}kr";
        }
    }
}

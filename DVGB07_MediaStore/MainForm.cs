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
    public partial class MainForm : Form
    {
        BindingList<Book> books;
        BindingSource booksSource;
        BindingList<Game> games;
        BindingSource gamesSource;
        BindingList<Movie> movies;
        BindingSource moviesSource;
        BindingList<Product> cartItems;
        BindingSource cartSource;

        public MainForm()
        {
            InitializeComponent();

            books = new BindingList<Book>();
            booksSource = new BindingSource(books, null);
            games = new BindingList<Game>();
            gamesSource = new BindingSource(games, null);
            movies = new BindingList<Movie>();
            moviesSource = new BindingSource(movies, null);
            cartItems = new BindingList<Product>();
            cartSource = new BindingSource(cartItems, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InventoryControl inventoryControl = new InventoryControl(booksSource, gamesSource, moviesSource);
            inventoryControl.Dock = DockStyle.Fill;
            InventoryTab.Controls.Add(inventoryControl);

            StoreControl storeControl = new StoreControl(booksSource, gamesSource, moviesSource, cartSource);
            storeControl.Dock = DockStyle.Fill;
            StoreTab.Controls.Add(storeControl);
        }
    }
}
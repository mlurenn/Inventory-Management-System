namespace Media_Store
{
    partial class InventoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.booksDataGrid = new System.Windows.Forms.DataGridView();
            this.addBookButton = new System.Windows.Forms.Button();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.GamesLabel = new System.Windows.Forms.Label();
            this.gamesDataGrid = new System.Windows.Forms.DataGridView();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.moviesDataGrid = new System.Windows.Forms.DataGridView();
            this.addGameButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGrid
            // 
            this.booksDataGrid.AllowUserToAddRows = false;
            this.booksDataGrid.AllowUserToDeleteRows = false;
            this.booksDataGrid.AllowUserToOrderColumns = true;
            this.booksDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGrid.Location = new System.Drawing.Point(3, 63);
            this.booksDataGrid.MultiSelect = false;
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.ReadOnly = true;
            this.booksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGrid.ShowCellErrors = false;
            this.booksDataGrid.ShowCellToolTips = false;
            this.booksDataGrid.ShowEditingIcon = false;
            this.booksDataGrid.ShowRowErrors = false;
            this.booksDataGrid.Size = new System.Drawing.Size(556, 100);
            this.booksDataGrid.TabIndex = 0;
            this.booksDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(476, 40);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(65, 20);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksLabel.Location = new System.Drawing.Point(3, 40);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(54, 20);
            this.BooksLabel.TabIndex = 3;
            this.BooksLabel.Text = "Books";
            // 
            // GamesLabel
            // 
            this.GamesLabel.AutoSize = true;
            this.GamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesLabel.Location = new System.Drawing.Point(6, 178);
            this.GamesLabel.Name = "GamesLabel";
            this.GamesLabel.Size = new System.Drawing.Size(61, 20);
            this.GamesLabel.TabIndex = 4;
            this.GamesLabel.Text = "Games";
            // 
            // gamesDataGrid
            // 
            this.gamesDataGrid.AllowUserToAddRows = false;
            this.gamesDataGrid.AllowUserToDeleteRows = false;
            this.gamesDataGrid.AllowUserToOrderColumns = true;
            this.gamesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGrid.Location = new System.Drawing.Point(3, 201);
            this.gamesDataGrid.MultiSelect = false;
            this.gamesDataGrid.Name = "gamesDataGrid";
            this.gamesDataGrid.ReadOnly = true;
            this.gamesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesDataGrid.ShowCellErrors = false;
            this.gamesDataGrid.ShowCellToolTips = false;
            this.gamesDataGrid.ShowEditingIcon = false;
            this.gamesDataGrid.ShowRowErrors = false;
            this.gamesDataGrid.Size = new System.Drawing.Size(556, 100);
            this.gamesDataGrid.TabIndex = 5;
            this.gamesDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesLabel.Location = new System.Drawing.Point(6, 323);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(58, 20);
            this.MoviesLabel.TabIndex = 6;
            this.MoviesLabel.Text = "Movies";
            // 
            // moviesDataGrid
            // 
            this.moviesDataGrid.AllowUserToAddRows = false;
            this.moviesDataGrid.AllowUserToDeleteRows = false;
            this.moviesDataGrid.AllowUserToOrderColumns = true;
            this.moviesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGrid.Location = new System.Drawing.Point(3, 346);
            this.moviesDataGrid.MultiSelect = false;
            this.moviesDataGrid.Name = "moviesDataGrid";
            this.moviesDataGrid.ReadOnly = true;
            this.moviesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesDataGrid.ShowCellErrors = false;
            this.moviesDataGrid.ShowCellToolTips = false;
            this.moviesDataGrid.ShowEditingIcon = false;
            this.moviesDataGrid.ShowRowErrors = false;
            this.moviesDataGrid.Size = new System.Drawing.Size(556, 100);
            this.moviesDataGrid.TabIndex = 7;
            this.moviesDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(476, 179);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(65, 20);
            this.addGameButton.TabIndex = 8;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(470, 324);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(71, 20);
            this.addMovieButton.TabIndex = 9;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(423, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(118, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // orderProductButton
            // 
            this.orderProductButton.Location = new System.Drawing.Point(299, 3);
            this.orderProductButton.Name = "orderProductButton";
            this.orderProductButton.Size = new System.Drawing.Size(118, 23);
            this.orderProductButton.TabIndex = 11;
            this.orderProductButton.Text = "Order Selected";
            this.orderProductButton.UseVisualStyleBackColor = true;
            this.orderProductButton.Click += new System.EventHandler(this.orderProductButton_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderProductButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.moviesDataGrid);
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.gamesDataGrid);
            this.Controls.Add(this.GamesLabel);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.booksDataGrid);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(562, 449);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGrid;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.Label GamesLabel;
        private System.Windows.Forms.DataGridView gamesDataGrid;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.DataGridView moviesDataGrid;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button orderProductButton;
    }
}
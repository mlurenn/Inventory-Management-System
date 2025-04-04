namespace DVGB07_MediaStore
{
    partial class StoreControl
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
            this.moviesDataGrid = new System.Windows.Forms.DataGridView();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.gamesDataGrid = new System.Windows.Forms.DataGridView();
            this.GamesLabel = new System.Windows.Forms.Label();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.booksDataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.cartDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesDataGrid
            // 
            this.moviesDataGrid.AllowUserToAddRows = false;
            this.moviesDataGrid.AllowUserToDeleteRows = false;
            this.moviesDataGrid.AllowUserToOrderColumns = true;
            this.moviesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGrid.Location = new System.Drawing.Point(10, 373);
            this.moviesDataGrid.MultiSelect = false;
            this.moviesDataGrid.Name = "moviesDataGrid";
            this.moviesDataGrid.ReadOnly = true;
            this.moviesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesDataGrid.ShowCellErrors = false;
            this.moviesDataGrid.ShowCellToolTips = false;
            this.moviesDataGrid.ShowEditingIcon = false;
            this.moviesDataGrid.ShowRowErrors = false;
            this.moviesDataGrid.Size = new System.Drawing.Size(683, 130);
            this.moviesDataGrid.TabIndex = 16;
            this.moviesDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesLabel.Location = new System.Drawing.Point(13, 350);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(58, 20);
            this.MoviesLabel.TabIndex = 15;
            this.MoviesLabel.Text = "Movies";
            // 
            // gamesDataGrid
            // 
            this.gamesDataGrid.AllowUserToAddRows = false;
            this.gamesDataGrid.AllowUserToDeleteRows = false;
            this.gamesDataGrid.AllowUserToOrderColumns = true;
            this.gamesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGrid.Location = new System.Drawing.Point(10, 215);
            this.gamesDataGrid.MultiSelect = false;
            this.gamesDataGrid.Name = "gamesDataGrid";
            this.gamesDataGrid.ReadOnly = true;
            this.gamesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesDataGrid.ShowCellErrors = false;
            this.gamesDataGrid.ShowCellToolTips = false;
            this.gamesDataGrid.ShowEditingIcon = false;
            this.gamesDataGrid.ShowRowErrors = false;
            this.gamesDataGrid.Size = new System.Drawing.Size(683, 130);
            this.gamesDataGrid.TabIndex = 14;
            this.gamesDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // GamesLabel
            // 
            this.GamesLabel.AutoSize = true;
            this.GamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesLabel.Location = new System.Drawing.Point(13, 189);
            this.GamesLabel.Name = "GamesLabel";
            this.GamesLabel.Size = new System.Drawing.Size(61, 20);
            this.GamesLabel.TabIndex = 13;
            this.GamesLabel.Text = "Games";
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksLabel.Location = new System.Drawing.Point(6, 21);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(54, 20);
            this.BooksLabel.TabIndex = 12;
            this.BooksLabel.Text = "Books";
            // 
            // booksDataGrid
            // 
            this.booksDataGrid.AllowUserToAddRows = false;
            this.booksDataGrid.AllowUserToDeleteRows = false;
            this.booksDataGrid.AllowUserToOrderColumns = true;
            this.booksDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGrid.Location = new System.Drawing.Point(10, 47);
            this.booksDataGrid.MultiSelect = false;
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.ReadOnly = true;
            this.booksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGrid.ShowCellErrors = false;
            this.booksDataGrid.ShowCellToolTips = false;
            this.booksDataGrid.ShowEditingIcon = false;
            this.booksDataGrid.ShowRowErrors = false;
            this.booksDataGrid.Size = new System.Drawing.Size(690, 130);
            this.booksDataGrid.TabIndex = 10;
            this.booksDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addToCartButton);
            this.splitContainer1.Panel1.Controls.Add(this.gamesDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.booksDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.moviesDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.BooksLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MoviesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.GamesLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.buyButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeFromCartButton);
            this.splitContainer1.Panel2.Controls.Add(this.cartDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(943, 514);
            this.splitContainer1.SplitterDistance = 696;
            this.splitContainer1.TabIndex = 19;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(318, 18);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(75, 23);
            this.addToCartButton.TabIndex = 17;
            this.addToCartButton.Text = "Add to cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(4, 468);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(87, 20);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Total Price:";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(122, 488);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(118, 23);
            this.buyButton.TabIndex = 18;
            this.buyButton.Text = "Complete Purchase";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Location = new System.Drawing.Point(3, 488);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Size = new System.Drawing.Size(118, 23);
            this.removeFromCartButton.TabIndex = 18;
            this.removeFromCartButton.Text = "Remove Product";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // cartDataGrid
            // 
            this.cartDataGrid.AllowUserToAddRows = false;
            this.cartDataGrid.AllowUserToDeleteRows = false;
            this.cartDataGrid.AllowUserToOrderColumns = true;
            this.cartDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrid.Location = new System.Drawing.Point(-1, 3);
            this.cartDataGrid.MultiSelect = false;
            this.cartDataGrid.Name = "cartDataGrid";
            this.cartDataGrid.ReadOnly = true;
            this.cartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGrid.ShowCellErrors = false;
            this.cartDataGrid.ShowCellToolTips = false;
            this.cartDataGrid.ShowEditingIcon = false;
            this.cartDataGrid.ShowRowErrors = false;
            this.cartDataGrid.Size = new System.Drawing.Size(237, 458);
            this.cartDataGrid.TabIndex = 19;
            this.cartDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // StoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "StoreControl";
            this.Size = new System.Drawing.Size(943, 546);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView moviesDataGrid;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.DataGridView gamesDataGrid;
        private System.Windows.Forms.Label GamesLabel;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.DataGridView booksDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView cartDataGrid;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.Label priceLabel;
    }
}

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
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.GamesLabel = new System.Windows.Forms.Label();
            this.gamesDataGrid = new System.Windows.Forms.DataGridView();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.moviesDataGrid = new System.Windows.Forms.DataGridView();
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
            this.booksDataGrid.Location = new System.Drawing.Point(3, 32);
            this.booksDataGrid.MultiSelect = false;
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.ReadOnly = true;
            this.booksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGrid.ShowCellErrors = false;
            this.booksDataGrid.ShowCellToolTips = false;
            this.booksDataGrid.ShowEditingIcon = false;
            this.booksDataGrid.ShowRowErrors = false;
            this.booksDataGrid.Size = new System.Drawing.Size(609, 100);
            this.booksDataGrid.TabIndex = 0;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(258, 3);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(75, 23);
            this.AddItemBtn.TabIndex = 1;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksLabel.Location = new System.Drawing.Point(3, 9);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(54, 20);
            this.BooksLabel.TabIndex = 3;
            this.BooksLabel.Text = "Books";
            // 
            // GamesLabel
            // 
            this.GamesLabel.AutoSize = true;
            this.GamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesLabel.Location = new System.Drawing.Point(6, 147);
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
            this.gamesDataGrid.Location = new System.Drawing.Point(3, 170);
            this.gamesDataGrid.MultiSelect = false;
            this.gamesDataGrid.Name = "gamesDataGrid";
            this.gamesDataGrid.ReadOnly = true;
            this.gamesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesDataGrid.ShowCellErrors = false;
            this.gamesDataGrid.ShowCellToolTips = false;
            this.gamesDataGrid.ShowEditingIcon = false;
            this.gamesDataGrid.ShowRowErrors = false;
            this.gamesDataGrid.Size = new System.Drawing.Size(609, 100);
            this.gamesDataGrid.TabIndex = 5;
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesLabel.Location = new System.Drawing.Point(6, 292);
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
            this.moviesDataGrid.Location = new System.Drawing.Point(3, 315);
            this.moviesDataGrid.MultiSelect = false;
            this.moviesDataGrid.Name = "moviesDataGrid";
            this.moviesDataGrid.ReadOnly = true;
            this.moviesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesDataGrid.ShowCellErrors = false;
            this.moviesDataGrid.ShowCellToolTips = false;
            this.moviesDataGrid.ShowEditingIcon = false;
            this.moviesDataGrid.ShowRowErrors = false;
            this.moviesDataGrid.Size = new System.Drawing.Size(609, 100);
            this.moviesDataGrid.TabIndex = 7;
            // 
            // InvetoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviesDataGrid);
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.gamesDataGrid);
            this.Controls.Add(this.GamesLabel);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.booksDataGrid);
            this.Name = "InvetoryControl";
            this.Size = new System.Drawing.Size(615, 449);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGrid;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.Label GamesLabel;
        private System.Windows.Forms.DataGridView gamesDataGrid;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.DataGridView moviesDataGrid;
    }
}
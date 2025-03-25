namespace DVGB07_MediaStore
{
    partial class AddMovieForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genreText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addMovieLabel = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.formatText = new System.Windows.Forms.TextBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameBookLabel = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(62, 97);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 47;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(87, 217);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(5, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.AutoSize = true;
            this.addMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieLabel.Location = new System.Drawing.Point(21, 9);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Size = new System.Drawing.Size(133, 20);
            this.addMovieLabel.TabIndex = 44;
            this.addMovieLabel.Text = "Add a new movie:";
            // 
            // stockText
            // 
            this.stockText.Location = new System.Drawing.Point(62, 175);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(100, 20);
            this.stockText.TabIndex = 43;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(18, 185);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(42, 13);
            this.stockLabel.TabIndex = 42;
            this.stockLabel.Text = "*Stock:";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(62, 71);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 41;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(22, 78);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 13);
            this.priceLabel.TabIndex = 40;
            this.priceLabel.Text = "*Price:";
            // 
            // formatText
            // 
            this.formatText.Location = new System.Drawing.Point(62, 123);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(100, 20);
            this.formatText.TabIndex = 39;
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(18, 130);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(42, 13);
            this.formatLabel.TabIndex = 38;
            this.formatLabel.Text = "Format:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(21, 104);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 37;
            this.genreLabel.Text = "Genre:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(62, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 36;
            // 
            // nameBookLabel
            // 
            this.nameBookLabel.AutoSize = true;
            this.nameBookLabel.Location = new System.Drawing.Point(18, 52);
            this.nameBookLabel.Name = "nameBookLabel";
            this.nameBookLabel.Size = new System.Drawing.Size(42, 13);
            this.nameBookLabel.TabIndex = 35;
            this.nameBookLabel.Text = "*Name:";
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(62, 149);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(100, 20);
            this.lengthText.TabIndex = 48;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(18, 156);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 49;
            this.lengthLabel.Text = "Length:";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 252);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addMovieLabel);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.formatText);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameBookLabel);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addMovieLabel;
        private System.Windows.Forms.TextBox stockText;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameBookLabel;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Label lengthLabel;
    }
}
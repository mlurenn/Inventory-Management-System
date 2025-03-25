namespace DVGB07_MediaStore
{
    partial class AddGameForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addGameSLabel = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.platformText = new System.Windows.Forms.TextBox();
            this.platformLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameBookLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(94, 175);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addGameSLabel
            // 
            this.addGameSLabel.AutoSize = true;
            this.addGameSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameSLabel.Location = new System.Drawing.Point(28, 9);
            this.addGameSLabel.Name = "addGameSLabel";
            this.addGameSLabel.Size = new System.Drawing.Size(132, 20);
            this.addGameSLabel.TabIndex = 31;
            this.addGameSLabel.Text = "Add a new game:";
            // 
            // stockText
            // 
            this.stockText.Location = new System.Drawing.Point(69, 149);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(100, 20);
            this.stockText.TabIndex = 30;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(25, 156);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(42, 13);
            this.stockLabel.TabIndex = 29;
            this.stockLabel.Text = "*Stock:";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(69, 71);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 28;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(29, 78);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 13);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "*Price:";
            // 
            // platformText
            // 
            this.platformText.Location = new System.Drawing.Point(69, 123);
            this.platformText.Name = "platformText";
            this.platformText.Size = new System.Drawing.Size(100, 20);
            this.platformText.TabIndex = 26;
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(19, 130);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(48, 13);
            this.platformLabel.TabIndex = 25;
            this.platformLabel.Text = "Platform:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(28, 104);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 21;
            this.genreLabel.Text = "Genre:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(69, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 18;
            // 
            // nameBookLabel
            // 
            this.nameBookLabel.AutoSize = true;
            this.nameBookLabel.Location = new System.Drawing.Point(25, 52);
            this.nameBookLabel.Name = "nameBookLabel";
            this.nameBookLabel.Size = new System.Drawing.Size(42, 13);
            this.nameBookLabel.TabIndex = 17;
            this.nameBookLabel.Text = "*Name:";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(69, 97);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 34;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 204);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addGameSLabel);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.platformText);
            this.Controls.Add(this.platformLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameBookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGameForm";
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addGameSLabel;
        private System.Windows.Forms.TextBox stockText;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox platformText;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameBookLabel;
        private System.Windows.Forms.TextBox genreText;
    }
}
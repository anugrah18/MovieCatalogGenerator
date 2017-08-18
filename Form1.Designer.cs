namespace MovieCatalogGenerator
{
    partial class MovieCatalogGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCatalogGenerator));
            this.Browse = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.Catalog = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Gold;
            this.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Browse.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(270, 233);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(161, 56);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "BROWSe";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchtext
            // 
            this.searchtext.BackColor = System.Drawing.Color.White;
            this.searchtext.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(12, 171);
            this.searchtext.Name = "searchtext";
            this.searchtext.ReadOnly = true;
            this.searchtext.Size = new System.Drawing.Size(681, 39);
            this.searchtext.TabIndex = 1;
            // 
            // Catalog
            // 
            this.Catalog.BackColor = System.Drawing.Color.Gold;
            this.Catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Catalog.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalog.Location = new System.Drawing.Point(270, 332);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(161, 56);
            this.Catalog.TabIndex = 2;
            this.Catalog.Text = "CATALOg";
            this.Catalog.UseVisualStyleBackColor = false;
            this.Catalog.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(149, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 169);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gold;
            this.Exit.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(284, 426);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(131, 55);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "EXIt";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Gold;
            this.Help.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Location = new System.Drawing.Point(640, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(42, 37);
            this.Help.TabIndex = 16;
            this.Help.Text = "?";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.button4_Click);
            // 
            // MovieCatalogGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 505);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Catalog);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovieCatalogGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Catalog generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button Catalog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Help;
    }
}


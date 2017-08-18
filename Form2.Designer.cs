namespace MovieCatalogGenerator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SortByTitle = new System.Windows.Forms.RadioButton();
            this.sortByYear = new System.Windows.Forms.RadioButton();
            this.yearDisplay = new System.Windows.Forms.Label();
            this.SortByTitle2 = new System.Windows.Forms.RadioButton();
            this.SORT = new System.Windows.Forms.Button();
            this.sortByYear2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 47;
            this.listBox1.Location = new System.Drawing.Point(746, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(582, 423);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Limelight", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 446);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1438, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 892);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SortByTitle
            // 
            this.SortByTitle.AutoSize = true;
            this.SortByTitle.Checked = true;
            this.SortByTitle.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByTitle.ForeColor = System.Drawing.Color.Coral;
            this.SortByTitle.Location = new System.Drawing.Point(746, 600);
            this.SortByTitle.Name = "SortByTitle";
            this.SortByTitle.Size = new System.Drawing.Size(318, 39);
            this.SortByTitle.TabIndex = 5;
            this.SortByTitle.TabStop = true;
            this.SortByTitle.Text = "Sort By Title (Ascending)";
            this.SortByTitle.UseVisualStyleBackColor = true;
            // 
            // sortByYear
            // 
            this.sortByYear.AutoSize = true;
            this.sortByYear.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByYear.ForeColor = System.Drawing.Color.Coral;
            this.sortByYear.Location = new System.Drawing.Point(746, 686);
            this.sortByYear.Name = "sortByYear";
            this.sortByYear.Size = new System.Drawing.Size(318, 39);
            this.sortByYear.TabIndex = 6;
            this.sortByYear.Text = "Sort By Year (Ascending)";
            this.sortByYear.UseVisualStyleBackColor = true;
            // 
            // yearDisplay
            // 
            this.yearDisplay.AutoSize = true;
            this.yearDisplay.Font = new System.Drawing.Font("Castellar", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearDisplay.Location = new System.Drawing.Point(13, 13);
            this.yearDisplay.Name = "yearDisplay";
            this.yearDisplay.Size = new System.Drawing.Size(126, 34);
            this.yearDisplay.TabIndex = 7;
            this.yearDisplay.Text = "label1";
            // 
            // SortByTitle2
            // 
            this.SortByTitle2.AutoSize = true;
            this.SortByTitle2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByTitle2.ForeColor = System.Drawing.Color.Coral;
            this.SortByTitle2.Location = new System.Drawing.Point(1083, 600);
            this.SortByTitle2.Name = "SortByTitle2";
            this.SortByTitle2.Size = new System.Drawing.Size(332, 39);
            this.SortByTitle2.TabIndex = 8;
            this.SortByTitle2.Text = "Sort By Title (Descending)";
            this.SortByTitle2.UseVisualStyleBackColor = true;
            // 
            // SORT
            // 
            this.SORT.BackColor = System.Drawing.Color.Gold;
            this.SORT.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SORT.ForeColor = System.Drawing.Color.Black;
            this.SORT.Location = new System.Drawing.Point(987, 801);
            this.SORT.Name = "SORT";
            this.SORT.Size = new System.Drawing.Size(131, 55);
            this.SORT.TabIndex = 9;
            this.SORT.Text = "SORt";
            this.SORT.UseVisualStyleBackColor = false;
            this.SORT.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortByYear2
            // 
            this.sortByYear2.AutoSize = true;
            this.sortByYear2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByYear2.ForeColor = System.Drawing.Color.Coral;
            this.sortByYear2.Location = new System.Drawing.Point(1083, 686);
            this.sortByYear2.Name = "sortByYear2";
            this.sortByYear2.Size = new System.Drawing.Size(332, 39);
            this.sortByYear2.TabIndex = 10;
            this.sortByYear2.Text = "Sort By Year (Descending)";
            this.sortByYear2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(12, 557);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 68);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Genres";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(19, 655);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(523, 366);
            this.webBrowser1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(1500, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 45);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(987, 894);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXIt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortByYear2);
            this.Controls.Add(this.SORT);
            this.Controls.Add(this.SortByTitle2);
            this.Controls.Add(this.yearDisplay);
            this.Controls.Add(this.sortByYear);
            this.Controls.Add(this.SortByTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies Catalog Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SortByTitle;
        private System.Windows.Forms.RadioButton sortByYear;
        private System.Windows.Forms.Label yearDisplay;
        private System.Windows.Forms.RadioButton SortByTitle2;
        private System.Windows.Forms.Button SORT;
        private System.Windows.Forms.RadioButton sortByYear2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}
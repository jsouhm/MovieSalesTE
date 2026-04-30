namespace MovieSalesT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMovieTitle = new Label();
            txtMovieTitle = new TextBox();
            lblMoviePrice = new Label();
            lblMovieGenre = new Label();
            numMoviePrice = new NumericUpDown();
            btnAddMovie = new Button();
            cboMovieGenre = new ComboBox();
            lstMovieOutput = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numMoviePrice).BeginInit();
            SuspendLayout();
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Location = new Point(109, 62);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(65, 15);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "Movie Title";
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(184, 59);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(226, 23);
            txtMovieTitle.TabIndex = 1;
            // 
            // lblMoviePrice
            // 
            lblMoviePrice.AutoSize = true;
            lblMoviePrice.Location = new Point(109, 95);
            lblMoviePrice.Name = "lblMoviePrice";
            lblMoviePrice.Size = new Size(69, 15);
            lblMoviePrice.TabIndex = 2;
            lblMoviePrice.Text = "Movie Price";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Location = new Point(109, 129);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(74, 15);
            lblMovieGenre.TabIndex = 4;
            lblMovieGenre.Text = "Movie Genre";
            // 
            // numMoviePrice
            // 
            numMoviePrice.DecimalPlaces = 2;
            numMoviePrice.Location = new Point(184, 93);
            numMoviePrice.Name = "numMoviePrice";
            numMoviePrice.Size = new Size(122, 23);
            numMoviePrice.TabIndex = 6;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(109, 297);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(75, 23);
            btnAddMovie.TabIndex = 7;
            btnAddMovie.Text = "&Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // cboMovieGenre
            // 
            cboMovieGenre.FormattingEnabled = true;
            cboMovieGenre.Location = new Point(184, 126);
            cboMovieGenre.Name = "cboMovieGenre";
            cboMovieGenre.Size = new Size(146, 23);
            cboMovieGenre.TabIndex = 8;
            cboMovieGenre.TextChanged += cboMovieGenre_TextChanged;
            // 
            // lstMovieOutput
            // 
            lstMovieOutput.FormattingEnabled = true;
            lstMovieOutput.HorizontalScrollbar = true;
            lstMovieOutput.Location = new Point(109, 169);
            lstMovieOutput.Name = "lstMovieOutput";
            lstMovieOutput.Size = new Size(301, 109);
            lstMovieOutput.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 378);
            Controls.Add(lstMovieOutput);
            Controls.Add(cboMovieGenre);
            Controls.Add(btnAddMovie);
            Controls.Add(numMoviePrice);
            Controls.Add(lblMovieGenre);
            Controls.Add(lblMoviePrice);
            Controls.Add(txtMovieTitle);
            Controls.Add(lblMovieTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMoviePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieTitle;
        private TextBox txtMovieTitle;
        private Label lblMoviePrice;
        private Label lblMovieGenre;
        private NumericUpDown numMoviePrice;
        private Button btnAddMovie;
        private ComboBox cboMovieGenre;
        private ListBox lstMovieOutput;
    }
}

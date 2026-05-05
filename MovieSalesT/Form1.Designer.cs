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
            btnClear = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)numMoviePrice).BeginInit();
            SuspendLayout();
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Location = new Point(109, 34);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(65, 15);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "Movie &Title";
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(184, 31);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(226, 23);
            txtMovieTitle.TabIndex = 1;
            // 
            // lblMoviePrice
            // 
            lblMoviePrice.AutoSize = true;
            lblMoviePrice.Location = new Point(141, 81);
            lblMoviePrice.Name = "lblMoviePrice";
            lblMoviePrice.Size = new Size(33, 15);
            lblMoviePrice.TabIndex = 2;
            lblMoviePrice.Text = "&Price";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Location = new Point(136, 127);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(38, 15);
            lblMovieGenre.TabIndex = 4;
            lblMovieGenre.Text = "&Genre";
            // 
            // numMoviePrice
            // 
            numMoviePrice.DecimalPlaces = 2;
            numMoviePrice.Location = new Point(184, 79);
            numMoviePrice.Name = "numMoviePrice";
            numMoviePrice.Size = new Size(122, 23);
            numMoviePrice.TabIndex = 3;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(109, 297);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(75, 23);
            btnAddMovie.TabIndex = 8;
            btnAddMovie.Text = "&Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // cboMovieGenre
            // 
            cboMovieGenre.FormattingEnabled = true;
            cboMovieGenre.Location = new Point(184, 124);
            cboMovieGenre.Name = "cboMovieGenre";
            cboMovieGenre.Size = new Size(146, 23);
            cboMovieGenre.Sorted = true;
            cboMovieGenre.TabIndex = 5;
            cboMovieGenre.TextChanged += cboMovieGenre_TextChanged;
            // 
            // lstMovieOutput
            // 
            lstMovieOutput.FormattingEnabled = true;
            lstMovieOutput.HorizontalScrollbar = true;
            lstMovieOutput.Location = new Point(109, 169);
            lstMovieOutput.Name = "lstMovieOutput";
            lstMovieOutput.Size = new Size(301, 109);
            lstMovieOutput.TabIndex = 6;
            lstMovieOutput.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(221, 297);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(335, 297);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 378);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(lstMovieOutput);
            Controls.Add(cboMovieGenre);
            Controls.Add(btnAddMovie);
            Controls.Add(numMoviePrice);
            Controls.Add(lblMovieGenre);
            Controls.Add(lblMoviePrice);
            Controls.Add(txtMovieTitle);
            Controls.Add(lblMovieTitle);
            Name = "Form1";
            Text = "Movie Entry";
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
        private Button btnClear;
        private Button btnQuit;
    }
}

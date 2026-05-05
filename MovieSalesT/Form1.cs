namespace MovieSalesT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string genreFile = "MovieGenre.txt";
        StreamReader sr;
        StreamWriter sw; // Corrected type from StreamReader to StreamWriter

        private void Form1_Load(object sender, EventArgs e)
        {
            sr = File.OpenText(genreFile);
            while (!sr.EndOfStream)
            {
                cboMovieGenre.Items.Add(sr.ReadLine().Trim());
            }
            sr.Close();
        }

        private void cboMovieGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(txtMovieTitle.Text, (double)numMoviePrice.Value, cboMovieGenre.Text);
            lstMovieOutput.Items.Add(movie);
            //add any new genre to combo box
            if (!cboMovieGenre.Items.Contains(movie.MovieGenre))
            {
                cboMovieGenre.Items.Add(movie.MovieGenre);
                sw = File.AppendText(genreFile);
                sw.WriteLine(movie.MovieGenre);
                sw.Close();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMovieTitle.Clear();
            cboMovieGenre.Text = "";
            numMoviePrice.Value = numMoviePrice.Minimum;
        }
    }
}

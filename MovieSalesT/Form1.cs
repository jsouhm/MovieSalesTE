namespace MovieSalesT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMovieGenre.Items.Add("Action");
            cboMovieGenre.Items.Add("Comedy");
            cboMovieGenre.Items.Add("Horror");
            cboMovieGenre.Items.Add("Sci-Fi");
            cboMovieGenre.Items.Add("Romance");
        }

        private void cboMovieGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(txtMovieTitle.Text, (double) numMoviePrice.Value, cboMovieGenre.Text);
            lstMovieOutput.Items.Add(movie);
        }
    }
}

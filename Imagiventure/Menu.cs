namespace Imagiventure
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            Name name = new Name();
            name.ShowDialog();
            this.Hide();

        }
    }
}
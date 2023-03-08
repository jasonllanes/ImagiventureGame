
namespace Imagiventure
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
           
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            T_1 t_1 = new T_1();
            t_1.Show();
            this.Hide();
        }
    }
}

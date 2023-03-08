using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagiventure
{
    public partial class Name : Form
    {
       

        public Name()
        {
            InitializeComponent();
        }
        public static String entered_name;
        private void btnNext_Click(object sender, EventArgs e)
        {
           if(tb_Name.Text == "")
            {
                MessageBox.Show("You don't have an answer");
            }
            else
            {
                MessageBox.Show("Welcome " + tb_Name.Text + "!");
                Intro intro = new Intro();
                intro.Show();
                this.Hide();
                
            }
        }
    }
}

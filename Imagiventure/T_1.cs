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
    public partial class T_1 : Form
    {
        public T_1()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            T_1_1 t = new T_1_1();
            t.Show();
            this.Hide();
        }
    }
}

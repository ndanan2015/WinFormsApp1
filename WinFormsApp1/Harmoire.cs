using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Harmoire : Form
    {
        public Harmoire()
        {
            InitializeComponent();
        }

        private void button_jdb_Click(object sender, EventArgs e)
        {
            Jdb j = new Jdb();
            j.Show();
            j.Size = new Size(1070, 660);
            this.Hide();
        }
    }
}

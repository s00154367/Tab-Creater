using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guitar_Tab_Creater
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            NewTab nt = new NewTab();
            nt.Show();

            this.Hide();
        }

        private void btnNewChord_Click(object sender, EventArgs e)
        {
            NewChord nc = new NewChord();
            nc.Show();

            this.Hide();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            Saved s = new Saved();
            s.Show();

            this.Hide();
        }
    }
}

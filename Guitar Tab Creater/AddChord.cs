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
    public partial class AddChord : Form
    {
        public AddChord()
        {
            InitializeComponent();
        }

        public void btnA_Click(object sender, EventArgs e)
        {
            
          

            using (NewChord nc = new NewChord())
            {
                if (nc.ShowDialog() == DialogResult.OK)
                {
                    btnA.Text = nc.Chord1;
                }
            }




            this.Hide();
        }
    }
}

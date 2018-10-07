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
    public partial class NewChord : Form
    {
        public NewChord()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void richTextBox1_click(object sender, EventArgs e)
        {
            AddChord ac = new AddChord();
            ac.Show();
        }

        public string Chord1
        {
            get { return txtChord.Text; }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            int ChordCounter = 0;
            Label Chord = new Label();
            Chord.Text = "Am";
            Chord.Name = "Chord" + ChordCounter;
            Chord.Font = new Font("Georgia", 16);
            Chord.Location = new Point(MousePosition.X, MousePosition.Y);
            Chord.Height = 50;
            Chord.Width = 50;
        }
    }
}

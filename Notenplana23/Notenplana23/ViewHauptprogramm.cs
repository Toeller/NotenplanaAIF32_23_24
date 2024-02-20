using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notenplana23
{
    public partial class ViewHauptprogramm : Form, IViewHauptprogramm
    {
        public ViewHauptprogramm()
        {
            InitializeComponent();
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            ViewProfil viewProfil = new ViewProfil();
            viewProfil.Show();

            this.Hide();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {

        }

        private void buttonFach1_Click(object sender, EventArgs e)
        {
            ViewFachHj1 viewFachHj1 = new ViewFachHj1();
            viewFachHj1.Show();

            this.Hide();
            
        }

        private void buttonNote1_Click(object sender, EventArgs e)
        {
            ViewNoteHj1 viewNoteHj1 = new ViewNoteHj1();
            viewNoteHj1.Show();

            this.Hide();
        }

        private void buttonFach2_Click(object sender, EventArgs e)
        {
            ViewFachHj2 viewFachHj2 = new ViewFachHj2();
            viewFachHj2.Show();

            this.Hide();
            
        }

        private void buttonNote2_Click(object sender, EventArgs e)
        {
            ViewNoteHj2 viewNoteHj2 = new ViewNoteHj2();
            viewNoteHj2.Show();

            this.Hide();
        }
    }
}
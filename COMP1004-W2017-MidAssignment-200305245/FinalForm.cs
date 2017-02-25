using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidAssignment_200305245
{
    public partial class FinalForm : Form
    {
        System.Windows.Forms.Form AbilityForm = System.Windows.Forms.Application.OpenForms["AbilityForm"];
        System.Windows.Forms.Form JobForme = System.Windows.Forms.Application.OpenForms["JobForm"];
        System.Windows.Forms.Form RaceForm = System.Windows.Forms.Application.OpenForms["RaceForm"];
        public FinalForm()
        {
            InitializeComponent();
            pictureBox1.Image = ((RaceForm)RaceForm).CharacterPictureBox.Image;
            textBox4.Text = ((JobForm)JobForme).GetJob();
            textBox5.Text = ((RaceForm)RaceForm).GetRace();
            textBox6.Text = ((JobForm)JobForme).GetHealth();
            STRTextBox.Text = ((AbilityForm)AbilityForm).STRTextBox.Text;
            DEXTextBox.Text = ((AbilityForm)AbilityForm).DEXTextBox.Text;
            INTTextBox.Text = ((AbilityForm)AbilityForm).INTTextBox.Text;
            CHATextBox.Text = ((AbilityForm)AbilityForm).CHATextBox.Text;
            PERTextBox.Text = ((AbilityForm)AbilityForm).PERTextBox.Text;
            ENDTextBox.Text = ((AbilityForm)AbilityForm).ENDTextBox.Text;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form is been printed", "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}

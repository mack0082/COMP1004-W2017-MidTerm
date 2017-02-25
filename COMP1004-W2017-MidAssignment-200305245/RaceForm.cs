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
    public partial class RaceForm : Form
    {
        public RaceForm()
        {
            InitializeComponent();
        }
        AbilityForm Ability = new AbilityForm();
        private void HumanButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HumanButton.Checked == true)
            {
                int str, dex, end, inttext, per, cha;
                Image image = Image.FromFile("c:/users/priyanka/documents/visual studio 2015/Projects/COMP1004-W2017-MidAssignment-200305245/COMP1004-W2017-MidAssignment-200305245/Resources/M_Human1.png");
                CharacterPictureBox.Image = image;
                /*str = Convert.ToInt32(Ability.STRTextBox.Text);
                dex = Convert.ToInt32(Ability.DEXTextBox.Text);
                end = Convert.ToInt32(Ability.ENDTextBox.Text);
                inttext = Convert.ToInt32(Ability.INTTextBox.Text);
                per = Convert.ToInt32(Ability.PERTextBox.Text);
                cha = Convert.ToInt32(Ability.CHATextBox.Text);
            */
            }

        }

        private void DrawfButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawfButton.Checked == true)
            {
                Image image = Image.FromFile("c:/users/priyanka/documents/visual studio 2015/Projects/COMP1004-W2017-MidAssignment-200305245/COMP1004-W2017-MidAssignment-200305245/Resources/M_Dwarf1.png");
                CharacterPictureBox.Image = image;
            }
        }
        private void ElfButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ElfButton.Checked == true)
            {
                Image image = Image.FromFile("c:/users/priyanka/documents/visual studio 2015/Projects/COMP1004-W2017-MidAssignment-200305245/COMP1004-W2017-MidAssignment-200305245/Resources/M_Elf1.png");
                CharacterPictureBox.Image = image;
            }
        }

        private void HalfingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HalfingButton.Checked == true)
            {
                Image image = Image.FromFile("c:/users/priyanka/documents/visual studio 2015/Projects/COMP1004-W2017-MidAssignment-200305245/COMP1004-W2017-MidAssignment-200305245/Resources/M_Halfling2.png");
                CharacterPictureBox.Image = image;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            JobForm jobFrom = new JobForm();
            jobFrom.Visible = true;

        }
        public string GetRace()
        {
            if (HumanButton.Checked == true)
                return "Human";
            if (DrawfButton.Checked == true)
                return "Drawf";
            if (HalfingButton.Checked == true)
                return "Halfing";
            return "Elf";
        }

        private void CharacterPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

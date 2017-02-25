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
    public partial class JobForm : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["AbilityForm"];


        int strtext, dextext, endtext, inttext, pertext, chatext;

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FinalForm final = new FinalForm();
            final.Visible = true;
        }

        public JobForm()
        {
            InitializeComponent();
        }

        private void SoliderButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoliderButton.Checked == true)
            {
                endtext = Convert.ToInt32(((AbilityForm)f).ENDTextBox.Text);
                endtext = endtext + 30;
                HealthPointLabel.Text = endtext.ToString();
            }
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RogueRadioButton.Checked == true)
            {
                dextext = Convert.ToInt32(((AbilityForm)f).DEXTextBox.Text);
                dextext = dextext + 28;
                HealthPointLabel.Text = dextext.ToString();
            }
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MagickerRadioButton.Checked == true)
            {
                inttext = Convert.ToInt32(((AbilityForm)f).INTTextBox.Text);
                inttext = inttext + 15;
                HealthPointLabel.Text = inttext.ToString();
            }
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CultistRadioButton.Checked == true)
            {
                chatext = Convert.ToInt32(((AbilityForm)f).CHATextBox.Text);
                chatext = chatext + 24;
                HealthPointLabel.Text = chatext.ToString();
            }
        }
        public string GetHealth()
        {
            return HealthPointLabel.Text.ToString();
        }
        public string GetJob()
        {
            if (SoliderButton.Checked == true)
                return "Solider";
            if (RogueRadioButton.Checked == true)
                return "Rogue";
            if (MagickerRadioButton.Checked == true)
                return "Magicker";
            return "Cultist";
        }
    }
}

namespace COMP1004_W2017_MidAssignment_200305245
{
    partial class RaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.RacialBonusLabel = new System.Windows.Forms.Label();
            this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
            this.RadioBottonGroupBox = new System.Windows.Forms.GroupBox();
            this.HalfingButton = new System.Windows.Forms.RadioButton();
            this.ElfButton = new System.Windows.Forms.RadioButton();
            this.DrawfButton = new System.Windows.Forms.RadioButton();
            this.HumanButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.RadioBottonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(239, 84);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 5;
            this.CharacterPictureBox.TabStop = false;
            this.CharacterPictureBox.Click += new System.EventHandler(this.CharacterPictureBox_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RacialBonusLabel
            // 
            this.RacialBonusLabel.AutoSize = true;
            this.RacialBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusLabel.Location = new System.Drawing.Point(236, 366);
            this.RacialBonusLabel.Name = "RacialBonusLabel";
            this.RacialBonusLabel.Size = new System.Drawing.Size(115, 20);
            this.RacialBonusLabel.TabIndex = 6;
            this.RacialBonusLabel.Text = "Racial Bonus";
            // 
            // RacialBonusTextBox
            // 
            this.RacialBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusTextBox.Location = new System.Drawing.Point(242, 400);
            this.RacialBonusTextBox.Name = "RacialBonusTextBox";
            this.RacialBonusTextBox.Size = new System.Drawing.Size(287, 29);
            this.RacialBonusTextBox.TabIndex = 7;
            // 
            // RadioBottonGroupBox
            // 
            this.RadioBottonGroupBox.Controls.Add(this.HalfingButton);
            this.RadioBottonGroupBox.Controls.Add(this.ElfButton);
            this.RadioBottonGroupBox.Controls.Add(this.DrawfButton);
            this.RadioBottonGroupBox.Controls.Add(this.HumanButton);
            this.RadioBottonGroupBox.Location = new System.Drawing.Point(13, 84);
            this.RadioBottonGroupBox.Name = "RadioBottonGroupBox";
            this.RadioBottonGroupBox.Size = new System.Drawing.Size(198, 115);
            this.RadioBottonGroupBox.TabIndex = 8;
            this.RadioBottonGroupBox.TabStop = false;
            this.RadioBottonGroupBox.Text = "Race Character";
            // 
            // HalfingButton
            // 
            this.HalfingButton.AutoSize = true;
            this.HalfingButton.Location = new System.Drawing.Point(22, 89);
            this.HalfingButton.Name = "HalfingButton";
            this.HalfingButton.Size = new System.Drawing.Size(58, 17);
            this.HalfingButton.TabIndex = 3;
            this.HalfingButton.TabStop = true;
            this.HalfingButton.Text = "Halfing";
            this.HalfingButton.UseVisualStyleBackColor = true;
            this.HalfingButton.CheckedChanged += new System.EventHandler(this.HalfingButton_CheckedChanged);
            // 
            // ElfButton
            // 
            this.ElfButton.AutoSize = true;
            this.ElfButton.Location = new System.Drawing.Point(22, 66);
            this.ElfButton.Name = "ElfButton";
            this.ElfButton.Size = new System.Drawing.Size(37, 17);
            this.ElfButton.TabIndex = 2;
            this.ElfButton.TabStop = true;
            this.ElfButton.Text = "Elf";
            this.ElfButton.UseVisualStyleBackColor = true;
            this.ElfButton.CheckedChanged += new System.EventHandler(this.ElfButton_CheckedChanged);
            // 
            // DrawfButton
            // 
            this.DrawfButton.AutoSize = true;
            this.DrawfButton.Location = new System.Drawing.Point(22, 43);
            this.DrawfButton.Name = "DrawfButton";
            this.DrawfButton.Size = new System.Drawing.Size(53, 17);
            this.DrawfButton.TabIndex = 1;
            this.DrawfButton.TabStop = true;
            this.DrawfButton.Text = "Drawf";
            this.DrawfButton.UseVisualStyleBackColor = true;
            this.DrawfButton.CheckedChanged += new System.EventHandler(this.DrawfButton_CheckedChanged);
            // 
            // HumanButton
            // 
            this.HumanButton.AutoSize = true;
            this.HumanButton.Location = new System.Drawing.Point(22, 20);
            this.HumanButton.Name = "HumanButton";
            this.HumanButton.Size = new System.Drawing.Size(59, 17);
            this.HumanButton.TabIndex = 0;
            this.HumanButton.TabStop = true;
            this.HumanButton.Text = "Human";
            this.HumanButton.UseVisualStyleBackColor = true;
            this.HumanButton.CheckedChanged += new System.EventHandler(this.HumanButton_CheckedChanged);
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(677, 519);
            this.Controls.Add(this.RadioBottonGroupBox);
            this.Controls.Add(this.RacialBonusTextBox);
            this.Controls.Add(this.RacialBonusLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.RadioBottonGroupBox.ResumeLayout(false);
            this.RadioBottonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
        private System.Windows.Forms.GroupBox RadioBottonGroupBox;
        private System.Windows.Forms.RadioButton HalfingButton;
        private System.Windows.Forms.RadioButton ElfButton;
        private System.Windows.Forms.RadioButton DrawfButton;
        private System.Windows.Forms.RadioButton HumanButton;
    }
}
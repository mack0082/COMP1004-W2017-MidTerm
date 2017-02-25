namespace COMP1004_W2017_MidAssignment_200305245
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.JobGroupBox = new System.Windows.Forms.GroupBox();
            this.SoliderButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.CultistRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthPointLabel = new System.Windows.Forms.Label();
            this.JobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // JobGroupBox
            // 
            this.JobGroupBox.Controls.Add(this.CultistRadioButton);
            this.JobGroupBox.Controls.Add(this.MagickerRadioButton);
            this.JobGroupBox.Controls.Add(this.RogueRadioButton);
            this.JobGroupBox.Controls.Add(this.SoliderButton);
            this.JobGroupBox.Location = new System.Drawing.Point(25, 89);
            this.JobGroupBox.Name = "JobGroupBox";
            this.JobGroupBox.Size = new System.Drawing.Size(200, 130);
            this.JobGroupBox.TabIndex = 4;
            this.JobGroupBox.TabStop = false;
            this.JobGroupBox.Text = "Job";
            // 
            // SoliderButton
            // 
            this.SoliderButton.AutoSize = true;
            this.SoliderButton.Location = new System.Drawing.Point(6, 19);
            this.SoliderButton.Name = "SoliderButton";
            this.SoliderButton.Size = new System.Drawing.Size(57, 17);
            this.SoliderButton.TabIndex = 0;
            this.SoliderButton.TabStop = true;
            this.SoliderButton.Text = "Solider";
            this.SoliderButton.UseVisualStyleBackColor = true;
            this.SoliderButton.CheckedChanged += new System.EventHandler(this.SoliderButton_CheckedChanged);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(6, 42);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(57, 17);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Text = "Rouge";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Location = new System.Drawing.Point(6, 65);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.TabStop = true;
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this.MagickerRadioButton_CheckedChanged);
            // 
            // CultistRadioButton
            // 
            this.CultistRadioButton.AutoSize = true;
            this.CultistRadioButton.Location = new System.Drawing.Point(6, 88);
            this.CultistRadioButton.Name = "CultistRadioButton";
            this.CultistRadioButton.Size = new System.Drawing.Size(53, 17);
            this.CultistRadioButton.TabIndex = 3;
            this.CultistRadioButton.TabStop = true;
            this.CultistRadioButton.Text = "Cultist";
            this.CultistRadioButton.UseVisualStyleBackColor = true;
            this.CultistRadioButton.CheckedChanged += new System.EventHandler(this.CultistRadioButton_CheckedChanged);
            // 
            // HealthPointLabel
            // 
            this.HealthPointLabel.AutoSize = true;
            this.HealthPointLabel.Location = new System.Drawing.Point(361, 141);
            this.HealthPointLabel.Name = "HealthPointLabel";
            this.HealthPointLabel.Size = new System.Drawing.Size(0, 13);
            this.HealthPointLabel.TabIndex = 5;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.HealthPointLabel);
            this.Controls.Add(this.JobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.JobGroupBox.ResumeLayout(false);
            this.JobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox JobGroupBox;
        private System.Windows.Forms.RadioButton CultistRadioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoliderButton;
        private System.Windows.Forms.Label HealthPointLabel;
    }
}
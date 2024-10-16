namespace HangmanGame
{
    partial class Form1
    {
        // Component field definitions
        private DevExpress.XtraEditors.LabelControl labelHangman; // For Hangman graphic
        private DevExpress.XtraEditors.LabelControl labelWordProgress; // For the word's progress
        private DevExpress.XtraEditors.SimpleButton buttonGuess; // Guess button
        private DevExpress.XtraEditors.TextEdit textBoxLetter; // Input field for letter guesses

        // Layout and properties settings for the components on the form
        private void InitializeComponent()
        {
            this.labelHangman = new DevExpress.XtraEditors.LabelControl();
            this.labelWordProgress = new DevExpress.XtraEditors.LabelControl();
            this.buttonGuess = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxLetter = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLetter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHangman
            // 
            this.labelHangman.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.labelHangman.Appearance.Options.UseFont = true;
            this.labelHangman.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelHangman.Location = new System.Drawing.Point(12, 12);
            this.labelHangman.Name = "labelHangman";
            this.labelHangman.Size = new System.Drawing.Size(300, 100);
            this.labelHangman.TabIndex = 0;
            this.labelHangman.Text = "Hangman";
            // 
            // labelWordProgress
            // 
            this.labelWordProgress.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelWordProgress.Appearance.Options.UseFont = true;
            this.labelWordProgress.Location = new System.Drawing.Point(12, 150);
            this.labelWordProgress.Name = "labelWordProgress";
            this.labelWordProgress.Size = new System.Drawing.Size(126, 28);
            this.labelWordProgress.TabIndex = 1;
            this.labelWordProgress.Text = "_ _ _ _ _ _";
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(80, 200);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(100, 23);
            this.buttonGuess.TabIndex = 3;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(12, 200);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(50, 22);
            this.textBoxLetter.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelWordProgress);
            this.Controls.Add(this.labelHangman);
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLetter.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

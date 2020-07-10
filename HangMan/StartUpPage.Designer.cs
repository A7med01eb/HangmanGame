namespace HangMan
{
    partial class StartUpPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.NormalButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(251, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Level";
            // 
            // EasyButton
            // 
            this.EasyButton.Font = new System.Drawing.Font("Tahoma", 24F);
            this.EasyButton.Location = new System.Drawing.Point(330, 197);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(133, 48);
            this.EasyButton.TabIndex = 1;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // NormalButton
            // 
            this.NormalButton.Font = new System.Drawing.Font("Tahoma", 24F);
            this.NormalButton.Location = new System.Drawing.Point(330, 255);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(133, 48);
            this.NormalButton.TabIndex = 2;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.Font = new System.Drawing.Font("Tahoma", 24F);
            this.HardButton.Location = new System.Drawing.Point(330, 316);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(133, 48);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // StartUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangMan.Properties.Resources.wood_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.NormalButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.label1);
            this.Name = "StartUpPage";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button HardButton;
    }
}
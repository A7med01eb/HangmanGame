namespace HangMan
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdF = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.cmdN = new System.Windows.Forms.Button();
            this.cmdM = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            this.cmdK = new System.Windows.Forms.Button();
            this.cmdJ = new System.Windows.Forms.Button();
            this.cmdI = new System.Windows.Forms.Button();
            this.cmdT = new System.Windows.Forms.Button();
            this.cmdS = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdQ = new System.Windows.Forms.Button();
            this.cmdP = new System.Windows.Forms.Button();
            this.cmdO = new System.Windows.Forms.Button();
            this.cmdY = new System.Windows.Forms.Button();
            this.cmdX = new System.Windows.Forms.Button();
            this.cmdW = new System.Windows.Forms.Button();
            this.cmdV = new System.Windows.Forms.Button();
            this.cmdZ = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AgainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.Image = global::HangMan.Properties.Resources._1;
            this.hangImage.Location = new System.Drawing.Point(12, 12);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(287, 324);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // cmdA
            // 
            this.cmdA.Location = new System.Drawing.Point(314, 32);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(54, 52);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.Location = new System.Drawing.Point(374, 32);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(54, 52);
            this.cmdB.TabIndex = 2;
            this.cmdB.Text = "B";
            this.cmdB.UseVisualStyleBackColor = true;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdD
            // 
            this.cmdD.Location = new System.Drawing.Point(494, 32);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(54, 52);
            this.cmdD.TabIndex = 4;
            this.cmdD.Text = "D";
            this.cmdD.UseVisualStyleBackColor = true;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdC
            // 
            this.cmdC.Location = new System.Drawing.Point(434, 32);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(54, 52);
            this.cmdC.TabIndex = 3;
            this.cmdC.Text = "C";
            this.cmdC.UseVisualStyleBackColor = true;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdH
            // 
            this.cmdH.Location = new System.Drawing.Point(734, 32);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(54, 52);
            this.cmdH.TabIndex = 8;
            this.cmdH.Text = "H";
            this.cmdH.UseVisualStyleBackColor = true;
            this.cmdH.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdG
            // 
            this.cmdG.Location = new System.Drawing.Point(674, 32);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(54, 52);
            this.cmdG.TabIndex = 7;
            this.cmdG.Text = "G";
            this.cmdG.UseVisualStyleBackColor = true;
            this.cmdG.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdF
            // 
            this.cmdF.Location = new System.Drawing.Point(614, 32);
            this.cmdF.Name = "cmdF";
            this.cmdF.Size = new System.Drawing.Size(54, 52);
            this.cmdF.TabIndex = 6;
            this.cmdF.Text = "F";
            this.cmdF.UseVisualStyleBackColor = true;
            this.cmdF.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.Location = new System.Drawing.Point(554, 32);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(54, 52);
            this.cmdE.TabIndex = 5;
            this.cmdE.Text = "E";
            this.cmdE.UseVisualStyleBackColor = true;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdN
            // 
            this.cmdN.Location = new System.Drawing.Point(674, 90);
            this.cmdN.Name = "cmdN";
            this.cmdN.Size = new System.Drawing.Size(54, 52);
            this.cmdN.TabIndex = 15;
            this.cmdN.Text = "N";
            this.cmdN.UseVisualStyleBackColor = true;
            this.cmdN.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdM
            // 
            this.cmdM.Location = new System.Drawing.Point(614, 90);
            this.cmdM.Name = "cmdM";
            this.cmdM.Size = new System.Drawing.Size(54, 52);
            this.cmdM.TabIndex = 14;
            this.cmdM.Text = "M";
            this.cmdM.UseVisualStyleBackColor = true;
            this.cmdM.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdL
            // 
            this.cmdL.Location = new System.Drawing.Point(554, 90);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(54, 52);
            this.cmdL.TabIndex = 13;
            this.cmdL.Text = "L";
            this.cmdL.UseVisualStyleBackColor = true;
            this.cmdL.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdK
            // 
            this.cmdK.Location = new System.Drawing.Point(494, 90);
            this.cmdK.Name = "cmdK";
            this.cmdK.Size = new System.Drawing.Size(54, 52);
            this.cmdK.TabIndex = 12;
            this.cmdK.Text = "K";
            this.cmdK.UseVisualStyleBackColor = true;
            this.cmdK.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdJ
            // 
            this.cmdJ.Location = new System.Drawing.Point(434, 90);
            this.cmdJ.Name = "cmdJ";
            this.cmdJ.Size = new System.Drawing.Size(54, 52);
            this.cmdJ.TabIndex = 11;
            this.cmdJ.Text = "J";
            this.cmdJ.UseVisualStyleBackColor = true;
            this.cmdJ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdI
            // 
            this.cmdI.Location = new System.Drawing.Point(374, 90);
            this.cmdI.Name = "cmdI";
            this.cmdI.Size = new System.Drawing.Size(54, 52);
            this.cmdI.TabIndex = 10;
            this.cmdI.Text = "I";
            this.cmdI.UseVisualStyleBackColor = true;
            this.cmdI.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdT
            // 
            this.cmdT.Location = new System.Drawing.Point(674, 148);
            this.cmdT.Name = "cmdT";
            this.cmdT.Size = new System.Drawing.Size(54, 52);
            this.cmdT.TabIndex = 21;
            this.cmdT.Text = "T";
            this.cmdT.UseVisualStyleBackColor = true;
            this.cmdT.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdS
            // 
            this.cmdS.Location = new System.Drawing.Point(614, 148);
            this.cmdS.Name = "cmdS";
            this.cmdS.Size = new System.Drawing.Size(54, 52);
            this.cmdS.TabIndex = 20;
            this.cmdS.Text = "S";
            this.cmdS.UseVisualStyleBackColor = true;
            this.cmdS.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdR
            // 
            this.cmdR.Location = new System.Drawing.Point(554, 148);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(54, 52);
            this.cmdR.TabIndex = 19;
            this.cmdR.Text = "R";
            this.cmdR.UseVisualStyleBackColor = true;
            this.cmdR.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdQ
            // 
            this.cmdQ.Location = new System.Drawing.Point(494, 148);
            this.cmdQ.Name = "cmdQ";
            this.cmdQ.Size = new System.Drawing.Size(54, 52);
            this.cmdQ.TabIndex = 18;
            this.cmdQ.Text = "Q";
            this.cmdQ.UseVisualStyleBackColor = true;
            this.cmdQ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdP
            // 
            this.cmdP.Location = new System.Drawing.Point(434, 148);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(54, 52);
            this.cmdP.TabIndex = 17;
            this.cmdP.Text = "P";
            this.cmdP.UseVisualStyleBackColor = true;
            this.cmdP.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdO
            // 
            this.cmdO.Location = new System.Drawing.Point(374, 148);
            this.cmdO.Name = "cmdO";
            this.cmdO.Size = new System.Drawing.Size(54, 52);
            this.cmdO.TabIndex = 16;
            this.cmdO.Text = "O";
            this.cmdO.UseVisualStyleBackColor = true;
            this.cmdO.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdY
            // 
            this.cmdY.Location = new System.Drawing.Point(586, 206);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(54, 52);
            this.cmdY.TabIndex = 27;
            this.cmdY.Text = "Y";
            this.cmdY.UseVisualStyleBackColor = true;
            this.cmdY.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdX
            // 
            this.cmdX.Location = new System.Drawing.Point(526, 206);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(54, 52);
            this.cmdX.TabIndex = 26;
            this.cmdX.Text = "X";
            this.cmdX.UseVisualStyleBackColor = true;
            this.cmdX.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdW
            // 
            this.cmdW.Location = new System.Drawing.Point(466, 206);
            this.cmdW.Name = "cmdW";
            this.cmdW.Size = new System.Drawing.Size(54, 52);
            this.cmdW.TabIndex = 25;
            this.cmdW.Text = "W";
            this.cmdW.UseVisualStyleBackColor = true;
            this.cmdW.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdV
            // 
            this.cmdV.Location = new System.Drawing.Point(406, 206);
            this.cmdV.Name = "cmdV";
            this.cmdV.Size = new System.Drawing.Size(54, 52);
            this.cmdV.TabIndex = 24;
            this.cmdV.Text = "V";
            this.cmdV.UseVisualStyleBackColor = true;
            this.cmdV.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdZ
            // 
            this.cmdZ.Location = new System.Drawing.Point(646, 206);
            this.cmdZ.Name = "cmdZ";
            this.cmdZ.Size = new System.Drawing.Size(54, 52);
            this.cmdZ.TabIndex = 28;
            this.cmdZ.Text = "Z";
            this.cmdZ.UseVisualStyleBackColor = true;
            this.cmdZ.Click += new System.EventHandler(this.guessClick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(397, 286);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 33);
            this.lblResult.TabIndex = 29;
            // 
            // lblShowWord
            // 
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.Location = new System.Drawing.Point(81, 397);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(638, 44);
            this.lblShowWord.TabIndex = 30;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(639, 339);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(149, 44);
            this.TimeLabel.TabIndex = 31;
            this.TimeLabel.Text = "0:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AgainButton
            // 
            this.AgainButton.BackgroundImage = global::HangMan.Properties.Resources.AgainIcon1;
            this.AgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgainButton.Location = new System.Drawing.Point(27, 349);
            this.AgainButton.Name = "AgainButton";
            this.AgainButton.Size = new System.Drawing.Size(45, 42);
            this.AgainButton.TabIndex = 32;
            this.AgainButton.UseVisualStyleBackColor = true;
            this.AgainButton.Click += new System.EventHandler(this.AgainButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HangMan.Properties.Resources.unnamed1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(79, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HangMan.Properties.Resources._207_2070585_back_png_image_background_transparent_background_back_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(27, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangMan.Properties.Resources.wood_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgainButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdZ);
            this.Controls.Add(this.cmdY);
            this.Controls.Add(this.cmdX);
            this.Controls.Add(this.cmdW);
            this.Controls.Add(this.cmdV);
            this.Controls.Add(this.cmdT);
            this.Controls.Add(this.cmdS);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdQ);
            this.Controls.Add(this.cmdP);
            this.Controls.Add(this.cmdO);
            this.Controls.Add(this.cmdN);
            this.Controls.Add(this.cmdM);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdK);
            this.Controls.Add(this.cmdJ);
            this.Controls.Add(this.cmdI);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdF);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.Name = "GameForm";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdF;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Button cmdN;
        private System.Windows.Forms.Button cmdM;
        private System.Windows.Forms.Button cmdL;
        private System.Windows.Forms.Button cmdK;
        private System.Windows.Forms.Button cmdJ;
        private System.Windows.Forms.Button cmdI;
        private System.Windows.Forms.Button cmdT;
        private System.Windows.Forms.Button cmdS;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdQ;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.Button cmdO;
        private System.Windows.Forms.Button cmdY;
        private System.Windows.Forms.Button cmdX;
        private System.Windows.Forms.Button cmdW;
        private System.Windows.Forms.Button cmdV;
        private System.Windows.Forms.Button cmdZ;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AgainButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


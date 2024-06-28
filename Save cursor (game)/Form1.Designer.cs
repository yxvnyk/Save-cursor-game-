namespace Save_cursor__game_
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbGameOver = new System.Windows.Forms.Label();
            this.lbScoreOnTheScreen = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbYourScore = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbGameOver
            // 
            this.lbGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGameOver.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbGameOver.Location = new System.Drawing.Point(9, 21);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(271, 36);
            this.lbGameOver.TabIndex = 2;
            this.lbGameOver.Text = "GAME OVER";
            this.lbGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScoreOnTheScreen
            // 
            this.lbScoreOnTheScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScoreOnTheScreen.AutoSize = true;
            this.lbScoreOnTheScreen.Font = new System.Drawing.Font("MV Boli", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreOnTheScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbScoreOnTheScreen.Location = new System.Drawing.Point(158, 121);
            this.lbScoreOnTheScreen.Name = "lbScoreOnTheScreen";
            this.lbScoreOnTheScreen.Size = new System.Drawing.Size(175, 183);
            this.lbScoreOnTheScreen.TabIndex = 3;
            this.lbScoreOnTheScreen.Text = "0";
            this.lbScoreOnTheScreen.SizeChanged += new System.EventHandler(this.lbScoreOnTheScreen_SizeChanged);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbYourScore);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.lbGameOver);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(91, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 6;
            // 
            // lbYourScore
            // 
            this.lbYourScore.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbYourScore.Location = new System.Drawing.Point(3, 80);
            this.lbYourScore.Name = "lbYourScore";
            this.lbYourScore.Size = new System.Drawing.Size(290, 31);
            this.lbYourScore.TabIndex = 9;
            this.lbYourScore.Text = "Your score:";
            this.lbYourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lbScore.Location = new System.Drawing.Point(131, 111);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(39, 40);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Location = new System.Drawing.Point(94, 184);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(109, 32);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(94, 242);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(109, 32);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbScoreOnTheScreen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.Label lbScoreOnTheScreen;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbYourScore;
        private System.Windows.Forms.Label lbScore;
    }
}


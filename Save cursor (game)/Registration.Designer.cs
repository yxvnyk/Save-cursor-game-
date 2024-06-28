namespace Save_cursor__game_
{
    partial class Registration
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
            this.btSignIn = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.lbRegistration = new System.Windows.Forms.Label();
            this.lbAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.Black;
            this.btSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSignIn.Location = new System.Drawing.Point(165, 184);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(96, 32);
            this.btSignIn.TabIndex = 12;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(75, 130);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(115, 22);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "PASSWORD";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPassword.Location = new System.Drawing.Point(247, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(131, 26);
            this.textBoxPassword.TabIndex = 10;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLogin.Location = new System.Drawing.Point(120, 79);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 22);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "LOGIN";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxLogin.Location = new System.Drawing.Point(247, 75);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(131, 26);
            this.textBoxLogin.TabIndex = 8;
            // 
            // lbRegistration
            // 
            this.lbRegistration.AutoSize = true;
            this.lbRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lbRegistration.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegistration.Location = new System.Drawing.Point(140, 20);
            this.lbRegistration.Name = "lbRegistration";
            this.lbRegistration.Size = new System.Drawing.Size(166, 30);
            this.lbRegistration.TabIndex = 7;
            this.lbRegistration.Text = "REGISTRATION";
            // 
            // lbAlert
            // 
            this.lbAlert.AutoSize = true;
            this.lbAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.lbAlert.Location = new System.Drawing.Point(142, 219);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(135, 13);
            this.lbAlert.TabIndex = 13;
            this.lbAlert.Text = "Such account already exist";
            this.lbAlert.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(446, 256);
            this.Controls.Add(this.lbAlert);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.lbRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label lbRegistration;
        private System.Windows.Forms.Label lbAlert;
    }
}
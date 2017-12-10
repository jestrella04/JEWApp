namespace JEWApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtLoginEmail.Location = new System.Drawing.Point(203, 118);
            this.txtLoginEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtLoginEmail.Location = new System.Drawing.Point(279, 301);
            this.txtLoginEmail.Margin = new System.Windows.Forms.Padding(6);
>>>>>>> refs/remotes/origin/master
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(341, 30);
            this.txtLoginEmail.TabIndex = 0;
            this.txtLoginEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(203, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label1.Location = new System.Drawing.Point(279, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
>>>>>>> refs/remotes/origin/master
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo electrónico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(204, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label2.Location = new System.Drawing.Point(281, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
>>>>>>> refs/remotes/origin/master
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtLoginPassword.Location = new System.Drawing.Point(204, 234);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtLoginPassword.Location = new System.Drawing.Point(281, 454);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(6);
>>>>>>> refs/remotes/origin/master
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(341, 30);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Crimson;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
<<<<<<< HEAD
            this.btnLogin.Location = new System.Drawing.Point(267, 358);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btnLogin.Location = new System.Drawing.Point(367, 605);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
>>>>>>> refs/remotes/origin/master
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 69);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
<<<<<<< HEAD
            this.lblLoginError.Location = new System.Drawing.Point(349, 303);
            this.lblLoginError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblLoginError.Location = new System.Drawing.Point(480, 538);
            this.lblLoginError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
>>>>>>> refs/remotes/origin/master
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(59, 20);
            this.lblLoginError.TabIndex = 5;
            this.lblLoginError.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(732, 503);
=======
            this.ClientSize = new System.Drawing.Size(1010, 786);
            this.Controls.Add(this.pictureBox1);
>>>>>>> refs/remotes/origin/master
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
>>>>>>> refs/remotes/origin/master
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JEWApp - Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginError;
        public System.Windows.Forms.TextBox txtLoginEmail;
        public System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace WindowsForms_lab_6_v1
{
    partial class SignIn
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
            this.SignIn_P = new System.Windows.Forms.Panel();
            this.SignUp_L = new System.Windows.Forms.Label();
            this.ForgotPas_L = new System.Windows.Forms.Label();
            this.SignIn_B = new System.Windows.Forms.Button();
            this.Password_CB = new System.Windows.Forms.CheckBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIn_P
            // 
            this.SignIn_P.Controls.Add(this.SignUp_L);
            this.SignIn_P.Controls.Add(this.ForgotPas_L);
            this.SignIn_P.Controls.Add(this.SignIn_B);
            this.SignIn_P.Controls.Add(this.Password_CB);
            this.SignIn_P.Controls.Add(this.Password_TB);
            this.SignIn_P.Controls.Add(this.Login_TB);
            this.SignIn_P.Controls.Add(this.Password_l);
            this.SignIn_P.Controls.Add(this.label2);
            this.SignIn_P.Controls.Add(this.label1);
            this.SignIn_P.Location = new System.Drawing.Point(0, 2);
            this.SignIn_P.Name = "SignIn_P";
            this.SignIn_P.Size = new System.Drawing.Size(424, 451);
            this.SignIn_P.TabIndex = 0;
            // 
            // SignUp_L
            // 
            this.SignUp_L.AutoSize = true;
            this.SignUp_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_L.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SignUp_L.Location = new System.Drawing.Point(230, 300);
            this.SignUp_L.Name = "SignUp_L";
            this.SignUp_L.Size = new System.Drawing.Size(169, 20);
            this.SignUp_L.TabIndex = 8;
            this.SignUp_L.Text = "Зарегестрироваться";
            this.SignUp_L.Click += new System.EventHandler(this.SignUp_L_Click);
            // 
            // ForgotPas_L
            // 
            this.ForgotPas_L.AutoSize = true;
            this.ForgotPas_L.BackColor = System.Drawing.SystemColors.Control;
            this.ForgotPas_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPas_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPas_L.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ForgotPas_L.Location = new System.Drawing.Point(32, 300);
            this.ForgotPas_L.Name = "ForgotPas_L";
            this.ForgotPas_L.Size = new System.Drawing.Size(118, 20);
            this.ForgotPas_L.TabIndex = 7;
            this.ForgotPas_L.Text = "Забыл пароль";
            this.ForgotPas_L.Click += new System.EventHandler(this.ForgotPas_L_Click);
            // 
            // SignIn_B
            // 
            this.SignIn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_B.Location = new System.Drawing.Point(49, 230);
            this.SignIn_B.Name = "SignIn_B";
            this.SignIn_B.Size = new System.Drawing.Size(331, 51);
            this.SignIn_B.TabIndex = 6;
            this.SignIn_B.Text = "Войти";
            this.SignIn_B.UseVisualStyleBackColor = true;
            this.SignIn_B.Click += new System.EventHandler(this.SignIn_B_Click);
            // 
            // Password_CB
            // 
            this.Password_CB.AutoSize = true;
            this.Password_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_CB.Location = new System.Drawing.Point(374, 190);
            this.Password_CB.Name = "Password_CB";
            this.Password_CB.Size = new System.Drawing.Size(15, 14);
            this.Password_CB.TabIndex = 5;
            this.Password_CB.UseVisualStyleBackColor = true;
            this.Password_CB.CheckedChanged += new System.EventHandler(this.Password_CB_CheckedChanged);
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TB.Location = new System.Drawing.Point(93, 179);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(275, 31);
            this.Password_TB.TabIndex = 4;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // Login_TB
            // 
            this.Login_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB.Location = new System.Drawing.Point(93, 132);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(275, 31);
            this.Login_TB.TabIndex = 3;
            // 
            // Password_l
            // 
            this.Password_l.AutoSize = true;
            this.Password_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_l.Location = new System.Drawing.Point(20, 184);
            this.Password_l.Name = "Password_l";
            this.Password_l.Size = new System.Drawing.Size(67, 20);
            this.Password_l.TabIndex = 2;
            this.Password_l.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войти";
            // 
            // SignInOrUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 342);
            this.Controls.Add(this.SignIn_P);
            this.Name = "SignInOrUp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInOrUp_FormClosed);
            this.SignIn_P.ResumeLayout(false);
            this.SignIn_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignIn_P;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label Password_l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Password_CB;
        private System.Windows.Forms.Button SignIn_B;
        private System.Windows.Forms.Label SignUp_L;
        private System.Windows.Forms.Label ForgotPas_L;
    }
}


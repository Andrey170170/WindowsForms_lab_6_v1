namespace WindowsForms_lab_6_v1
{
    partial class SignUp
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
            this.GoBack = new System.Windows.Forms.Label();
            this.Role_L = new System.Windows.Forms.Label();
            this.Role_CB = new System.Windows.Forms.ComboBox();
            this.SignUp_B = new System.Windows.Forms.Button();
            this.Password_CB = new System.Windows.Forms.CheckBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RepeatedPassword_ChB = new System.Windows.Forms.CheckBox();
            this.RepeatPassword_TB = new System.Windows.Forms.TextBox();
            this.RepeatPas_TB = new System.Windows.Forms.Label();
            this.SignIn_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIn_P
            // 
            this.SignIn_P.Controls.Add(this.RepeatedPassword_ChB);
            this.SignIn_P.Controls.Add(this.RepeatPassword_TB);
            this.SignIn_P.Controls.Add(this.RepeatPas_TB);
            this.SignIn_P.Controls.Add(this.GoBack);
            this.SignIn_P.Controls.Add(this.Role_L);
            this.SignIn_P.Controls.Add(this.Role_CB);
            this.SignIn_P.Controls.Add(this.SignUp_B);
            this.SignIn_P.Controls.Add(this.Password_CB);
            this.SignIn_P.Controls.Add(this.Password_TB);
            this.SignIn_P.Controls.Add(this.Login_TB);
            this.SignIn_P.Controls.Add(this.Password_l);
            this.SignIn_P.Controls.Add(this.label2);
            this.SignIn_P.Controls.Add(this.label1);
            this.SignIn_P.Location = new System.Drawing.Point(2, 2);
            this.SignIn_P.Name = "SignIn_P";
            this.SignIn_P.Size = new System.Drawing.Size(424, 451);
            this.SignIn_P.TabIndex = 1;
            // 
            // GoBack
            // 
            this.GoBack.AutoSize = true;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GoBack.Location = new System.Drawing.Point(42, 407);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(98, 18);
            this.GoBack.TabIndex = 9;
            this.GoBack.Text = "<- Вернуться";
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Role_L
            // 
            this.Role_L.AutoSize = true;
            this.Role_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_L.Location = new System.Drawing.Point(28, 303);
            this.Role_L.Name = "Role_L";
            this.Role_L.Size = new System.Drawing.Size(47, 20);
            this.Role_L.TabIndex = 8;
            this.Role_L.Text = "Роль";
            // 
            // Role_CB
            // 
            this.Role_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_CB.FormattingEnabled = true;
            this.Role_CB.Location = new System.Drawing.Point(101, 300);
            this.Role_CB.Name = "Role_CB";
            this.Role_CB.Size = new System.Drawing.Size(163, 28);
            this.Role_CB.TabIndex = 7;
            // 
            // SignUp_B
            // 
            this.SignUp_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_B.Location = new System.Drawing.Point(55, 338);
            this.SignUp_B.Name = "SignUp_B";
            this.SignUp_B.Size = new System.Drawing.Size(331, 51);
            this.SignUp_B.TabIndex = 6;
            this.SignUp_B.Text = "Зарегестрироваться";
            this.SignUp_B.UseVisualStyleBackColor = true;
            this.SignUp_B.Click += new System.EventHandler(this.SignUp_B_Click);
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
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зарегестрироваться";
            // 
            // RepeatedPassword_ChB
            // 
            this.RepeatedPassword_ChB.AutoSize = true;
            this.RepeatedPassword_ChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatedPassword_ChB.Location = new System.Drawing.Point(374, 266);
            this.RepeatedPassword_ChB.Name = "RepeatedPassword_ChB";
            this.RepeatedPassword_ChB.Size = new System.Drawing.Size(15, 14);
            this.RepeatedPassword_ChB.TabIndex = 12;
            this.RepeatedPassword_ChB.UseVisualStyleBackColor = true;
            this.RepeatedPassword_ChB.CheckedChanged += new System.EventHandler(this.RepeatedPassword_ChB_CheckedChanged);
            // 
            // RepeatPassword_TB
            // 
            this.RepeatPassword_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_TB.Location = new System.Drawing.Point(93, 255);
            this.RepeatPassword_TB.Name = "RepeatPassword_TB";
            this.RepeatPassword_TB.Size = new System.Drawing.Size(275, 31);
            this.RepeatPassword_TB.TabIndex = 11;
            this.RepeatPassword_TB.UseSystemPasswordChar = true;
            // 
            // RepeatPas_TB
            // 
            this.RepeatPas_TB.AutoSize = true;
            this.RepeatPas_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPas_TB.Location = new System.Drawing.Point(20, 224);
            this.RepeatPas_TB.Name = "RepeatPas_TB";
            this.RepeatPas_TB.Size = new System.Drawing.Size(152, 20);
            this.RepeatPas_TB.TabIndex = 10;
            this.RepeatPas_TB.Text = "Повторите пароль";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 457);
            this.Controls.Add(this.SignIn_P);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.SignIn_P.ResumeLayout(false);
            this.SignIn_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignIn_P;
        private System.Windows.Forms.Button SignUp_B;
        private System.Windows.Forms.CheckBox Password_CB;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label Password_l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Role_CB;
        private System.Windows.Forms.Label Role_L;
        private System.Windows.Forms.Label GoBack;
        private System.Windows.Forms.CheckBox RepeatedPassword_ChB;
        private System.Windows.Forms.TextBox RepeatPassword_TB;
        private System.Windows.Forms.Label RepeatPas_TB;
    }
}
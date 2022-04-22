namespace WindowsForms_lab_6_v1
{
    partial class AccArtist
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Profile_P = new System.Windows.Forms.TabPage();
            this.Profile_SpC = new System.Windows.Forms.SplitContainer();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Error_L = new System.Windows.Forms.Label();
            this.Password_CB = new System.Windows.Forms.CheckBox();
            this.Age_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Save_B = new System.Windows.Forms.Button();
            this.FullName_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_B = new System.Windows.Forms.Button();
            this.Portfolio_LV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.Orders_P = new System.Windows.Forms.TabPage();
            this.Portfolio_ImL = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.Profile_P.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_SpC)).BeginInit();
            this.Profile_SpC.Panel1.SuspendLayout();
            this.Profile_SpC.Panel2.SuspendLayout();
            this.Profile_SpC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profile_P);
            this.tabControl1.Controls.Add(this.Orders_P);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 788);
            this.tabControl1.TabIndex = 0;
            // 
            // Profile_P
            // 
            this.Profile_P.Controls.Add(this.Profile_SpC);
            this.Profile_P.Location = new System.Drawing.Point(4, 22);
            this.Profile_P.Name = "Profile_P";
            this.Profile_P.Padding = new System.Windows.Forms.Padding(3);
            this.Profile_P.Size = new System.Drawing.Size(1014, 762);
            this.Profile_P.TabIndex = 0;
            this.Profile_P.Text = "Профиль";
            this.Profile_P.UseVisualStyleBackColor = true;
            // 
            // Profile_SpC
            // 
            this.Profile_SpC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profile_SpC.Location = new System.Drawing.Point(3, 3);
            this.Profile_SpC.Name = "Profile_SpC";
            // 
            // Profile_SpC.Panel1
            // 
            this.Profile_SpC.Panel1.Controls.Add(this.Exit_B);
            this.Profile_SpC.Panel1.Controls.Add(this.Error_L);
            this.Profile_SpC.Panel1.Controls.Add(this.Password_CB);
            this.Profile_SpC.Panel1.Controls.Add(this.Age_TB);
            this.Profile_SpC.Panel1.Controls.Add(this.label5);
            this.Profile_SpC.Panel1.Controls.Add(this.Cancel_B);
            this.Profile_SpC.Panel1.Controls.Add(this.Save_B);
            this.Profile_SpC.Panel1.Controls.Add(this.FullName_TB);
            this.Profile_SpC.Panel1.Controls.Add(this.label4);
            this.Profile_SpC.Panel1.Controls.Add(this.Password_TB);
            this.Profile_SpC.Panel1.Controls.Add(this.label3);
            this.Profile_SpC.Panel1.Controls.Add(this.Login_TB);
            this.Profile_SpC.Panel1.Controls.Add(this.label2);
            this.Profile_SpC.Panel1.Controls.Add(this.label1);
            // 
            // Profile_SpC.Panel2
            // 
            this.Profile_SpC.Panel2.Controls.Add(this.Update_B);
            this.Profile_SpC.Panel2.Controls.Add(this.Portfolio_LV);
            this.Profile_SpC.Panel2.Controls.Add(this.label6);
            this.Profile_SpC.Size = new System.Drawing.Size(1008, 756);
            this.Profile_SpC.SplitterDistance = 451;
            this.Profile_SpC.TabIndex = 0;
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(143, 367);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(136, 37);
            this.Exit_B.TabIndex = 12;
            this.Exit_B.Text = "Выйти";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Error_L
            // 
            this.Error_L.AutoSize = true;
            this.Error_L.Location = new System.Drawing.Point(73, 298);
            this.Error_L.Name = "Error_L";
            this.Error_L.Size = new System.Drawing.Size(35, 13);
            this.Error_L.TabIndex = 11;
            this.Error_L.Text = "label6";
            // 
            // Password_CB
            // 
            this.Password_CB.AutoSize = true;
            this.Password_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_CB.Location = new System.Drawing.Point(380, 164);
            this.Password_CB.Name = "Password_CB";
            this.Password_CB.Size = new System.Drawing.Size(15, 14);
            this.Password_CB.TabIndex = 6;
            this.Password_CB.UseVisualStyleBackColor = true;
            this.Password_CB.CheckedChanged += new System.EventHandler(this.Password_CB_CheckedChanged);
            // 
            // Age_TB
            // 
            this.Age_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Age_TB.Location = new System.Drawing.Point(93, 250);
            this.Age_TB.Name = "Age_TB";
            this.Age_TB.Size = new System.Drawing.Size(281, 31);
            this.Age_TB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(15, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Возраст";
            // 
            // Cancel_B
            // 
            this.Cancel_B.Location = new System.Drawing.Point(238, 324);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(136, 37);
            this.Cancel_B.TabIndex = 8;
            this.Cancel_B.Text = "Сбросить";
            this.Cancel_B.UseVisualStyleBackColor = true;
            this.Cancel_B.Click += new System.EventHandler(this.Cancel_B_Click);
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(47, 324);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(136, 37);
            this.Save_B.TabIndex = 7;
            this.Save_B.Text = "Сохранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // FullName_TB
            // 
            this.FullName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.FullName_TB.Location = new System.Drawing.Point(93, 200);
            this.FullName_TB.Name = "FullName_TB";
            this.FullName_TB.Size = new System.Drawing.Size(281, 31);
            this.FullName_TB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ФИО";
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Password_TB.Location = new System.Drawing.Point(93, 153);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(281, 31);
            this.Password_TB.TabIndex = 4;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // Login_TB
            // 
            this.Login_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Login_TB.Location = new System.Drawing.Point(93, 103);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(281, 31);
            this.Login_TB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль";
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(444, 74);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(75, 23);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "Обновить";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Portfolio_LV
            // 
            this.Portfolio_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Portfolio_LV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Portfolio_LV.HideSelection = false;
            this.Portfolio_LV.Location = new System.Drawing.Point(51, 103);
            this.Portfolio_LV.Name = "Portfolio_LV";
            this.Portfolio_LV.Size = new System.Drawing.Size(469, 566);
            this.Portfolio_LV.TabIndex = 2;
            this.Portfolio_LV.UseCompatibleStateImageBehavior = false;
            this.Portfolio_LV.Click += new System.EventHandler(this.Portfolio_LV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 63);
            this.label6.TabIndex = 1;
            this.label6.Text = "Портфолио";
            // 
            // Orders_P
            // 
            this.Orders_P.Location = new System.Drawing.Point(4, 22);
            this.Orders_P.Name = "Orders_P";
            this.Orders_P.Padding = new System.Windows.Forms.Padding(3);
            this.Orders_P.Size = new System.Drawing.Size(1014, 762);
            this.Orders_P.TabIndex = 1;
            this.Orders_P.Text = "Заказы";
            this.Orders_P.UseVisualStyleBackColor = true;
            // 
            // Portfolio_ImL
            // 
            this.Portfolio_ImL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Portfolio_ImL.ImageSize = new System.Drawing.Size(16, 16);
            this.Portfolio_ImL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AccArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 788);
            this.Controls.Add(this.tabControl1);
            this.Name = "AccArtist";
            this.Text = "AccArtist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccArtist_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Profile_P.ResumeLayout(false);
            this.Profile_SpC.Panel1.ResumeLayout(false);
            this.Profile_SpC.Panel1.PerformLayout();
            this.Profile_SpC.Panel2.ResumeLayout(false);
            this.Profile_SpC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_SpC)).EndInit();
            this.Profile_SpC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Profile_P;
        private System.Windows.Forms.SplitContainer Profile_SpC;
        private System.Windows.Forms.TabPage Orders_P;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Age_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.TextBox FullName_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Password_CB;
        private System.Windows.Forms.Label Error_L;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.ListView Portfolio_LV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList Portfolio_ImL;
        private System.Windows.Forms.Button Update_B;
    }
}
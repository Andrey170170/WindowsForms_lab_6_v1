namespace WindowsForms_lab_6_v1
{
    partial class AccCustomer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.MyOrders_LV = new System.Windows.Forms.ListView();
            this.OrderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Exit_B);
            this.splitContainer1.Panel1.Controls.Add(this.Error_L);
            this.splitContainer1.Panel1.Controls.Add(this.Password_CB);
            this.splitContainer1.Panel1.Controls.Add(this.Age_TB);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.Cancel_B);
            this.splitContainer1.Panel1.Controls.Add(this.Save_B);
            this.splitContainer1.Panel1.Controls.Add(this.FullName_TB);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.Password_TB);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Login_TB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Add_B);
            this.splitContainer1.Panel2.Controls.Add(this.Update_B);
            this.splitContainer1.Panel2.Controls.Add(this.MyOrders_LV);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 780);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 0;
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(147, 380);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(136, 37);
            this.Exit_B.TabIndex = 40;
            this.Exit_B.Text = "Выйти";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Error_L
            // 
            this.Error_L.AutoSize = true;
            this.Error_L.Location = new System.Drawing.Point(77, 311);
            this.Error_L.Name = "Error_L";
            this.Error_L.Size = new System.Drawing.Size(35, 13);
            this.Error_L.TabIndex = 39;
            this.Error_L.Text = "label6";
            // 
            // Password_CB
            // 
            this.Password_CB.AutoSize = true;
            this.Password_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_CB.Location = new System.Drawing.Point(384, 177);
            this.Password_CB.Name = "Password_CB";
            this.Password_CB.Size = new System.Drawing.Size(15, 14);
            this.Password_CB.TabIndex = 33;
            this.Password_CB.UseVisualStyleBackColor = true;
            this.Password_CB.CheckedChanged += new System.EventHandler(this.Password_CB_CheckedChanged);
            // 
            // Age_TB
            // 
            this.Age_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Age_TB.Location = new System.Drawing.Point(97, 263);
            this.Age_TB.Name = "Age_TB";
            this.Age_TB.Size = new System.Drawing.Size(281, 31);
            this.Age_TB.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Возраст";
            // 
            // Cancel_B
            // 
            this.Cancel_B.Location = new System.Drawing.Point(242, 337);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(136, 37);
            this.Cancel_B.TabIndex = 36;
            this.Cancel_B.Text = "Сбросить";
            this.Cancel_B.UseVisualStyleBackColor = true;
            this.Cancel_B.Click += new System.EventHandler(this.Cancel_B_Click);
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(51, 337);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(136, 37);
            this.Save_B.TabIndex = 35;
            this.Save_B.Text = "Сохранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // FullName_TB
            // 
            this.FullName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.FullName_TB.Location = new System.Drawing.Point(97, 213);
            this.FullName_TB.Name = "FullName_TB";
            this.FullName_TB.Size = new System.Drawing.Size(281, 31);
            this.FullName_TB.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(19, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "ФИО";
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Password_TB.Location = new System.Drawing.Point(97, 166);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(281, 31);
            this.Password_TB.TabIndex = 31;
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Пароль";
            // 
            // Login_TB
            // 
            this.Login_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Login_TB.Location = new System.Drawing.Point(97, 116);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(281, 31);
            this.Login_TB.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 63);
            this.label1.TabIndex = 27;
            this.label1.Text = "Профиль";
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(64, 87);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(75, 23);
            this.Add_B.TabIndex = 31;
            this.Add_B.Text = "Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(680, 87);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(75, 23);
            this.Update_B.TabIndex = 30;
            this.Update_B.Text = "Обновить";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // MyOrders_LV
            // 
            this.MyOrders_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderName,
            this.Cost,
            this.OrderStatus});
            this.MyOrders_LV.FullRowSelect = true;
            this.MyOrders_LV.HideSelection = false;
            this.MyOrders_LV.Location = new System.Drawing.Point(64, 116);
            this.MyOrders_LV.Name = "MyOrders_LV";
            this.MyOrders_LV.Size = new System.Drawing.Size(691, 518);
            this.MyOrders_LV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MyOrders_LV.TabIndex = 29;
            this.MyOrders_LV.UseCompatibleStateImageBehavior = false;
            this.MyOrders_LV.View = System.Windows.Forms.View.Details;
            this.MyOrders_LV.Click += new System.EventHandler(this.MyOrders_LV_Click);
            // 
            // OrderName
            // 
            this.OrderName.Text = "Название";
            this.OrderName.Width = 400;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Статус";
            this.OrderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OrderStatus.Width = 160;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 63);
            this.label7.TabIndex = 28;
            this.label7.Text = "Мои заказы";
            // 
            // Cost
            // 
            this.Cost.Text = "Цена";
            this.Cost.Width = 100;
            // 
            // AccCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 780);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccCustomer";
            this.Text = "AccCustomer";
            this.Activated += new System.EventHandler(this.Update_B_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccCustomer_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Label Error_L;
        private System.Windows.Forms.CheckBox Password_CB;
        private System.Windows.Forms.TextBox Age_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.TextBox FullName_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView MyOrders_LV;
        private System.Windows.Forms.ColumnHeader OrderName;
        private System.Windows.Forms.ColumnHeader OrderStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.ColumnHeader Cost;
    }
}
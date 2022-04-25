namespace WindowsForms_lab_6_v1
{
    partial class OrderInProgressForm
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
            this.OrderCLogin_TB = new System.Windows.Forms.TextBox();
            this.OrderALogin_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderDecs_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderPrice_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderName_TB = new System.Windows.Forms.TextBox();
            this.Order_Img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Upload_B = new System.Windows.Forms.Button();
            this.SaveImg_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.End_B = new System.Windows.Forms.Button();
            this.Save_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.SaveImg_D = new System.Windows.Forms.SaveFileDialog();
            this.OrderImage_D = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderCLogin_TB
            // 
            this.OrderCLogin_TB.Enabled = false;
            this.OrderCLogin_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCLogin_TB.Location = new System.Drawing.Point(117, 395);
            this.OrderCLogin_TB.Name = "OrderCLogin_TB";
            this.OrderCLogin_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderCLogin_TB.TabIndex = 29;
            // 
            // OrderALogin_TB
            // 
            this.OrderALogin_TB.Enabled = false;
            this.OrderALogin_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderALogin_TB.Location = new System.Drawing.Point(117, 345);
            this.OrderALogin_TB.Name = "OrderALogin_TB";
            this.OrderALogin_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderALogin_TB.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Создатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название";
            // 
            // OrderDecs_TB
            // 
            this.OrderDecs_TB.Enabled = false;
            this.OrderDecs_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDecs_TB.Location = new System.Drawing.Point(117, 493);
            this.OrderDecs_TB.Multiline = true;
            this.OrderDecs_TB.Name = "OrderDecs_TB";
            this.OrderDecs_TB.Size = new System.Drawing.Size(500, 174);
            this.OrderDecs_TB.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Описание";
            // 
            // OrderPrice_TB
            // 
            this.OrderPrice_TB.Enabled = false;
            this.OrderPrice_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice_TB.Location = new System.Drawing.Point(117, 443);
            this.OrderPrice_TB.Name = "OrderPrice_TB";
            this.OrderPrice_TB.Size = new System.Drawing.Size(100, 29);
            this.OrderPrice_TB.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Цена";
            // 
            // OrderName_TB
            // 
            this.OrderName_TB.Enabled = false;
            this.OrderName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName_TB.Location = new System.Drawing.Point(117, 296);
            this.OrderName_TB.Name = "OrderName_TB";
            this.OrderName_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderName_TB.TabIndex = 21;
            // 
            // Order_Img
            // 
            this.Order_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Order_Img.Enabled = false;
            this.Order_Img.Location = new System.Drawing.Point(12, 12);
            this.Order_Img.Name = "Order_Img";
            this.Order_Img.Size = new System.Drawing.Size(605, 242);
            this.Order_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Order_Img.TabIndex = 20;
            this.Order_Img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Покупатель";
            // 
            // Upload_B
            // 
            this.Upload_B.Location = new System.Drawing.Point(32, 261);
            this.Upload_B.Name = "Upload_B";
            this.Upload_B.Size = new System.Drawing.Size(75, 23);
            this.Upload_B.TabIndex = 30;
            this.Upload_B.Text = "Загрузить";
            this.Upload_B.UseVisualStyleBackColor = true;
            this.Upload_B.Click += new System.EventHandler(this.Upload_B_Click);
            // 
            // SaveImg_B
            // 
            this.SaveImg_B.Location = new System.Drawing.Point(113, 260);
            this.SaveImg_B.Name = "SaveImg_B";
            this.SaveImg_B.Size = new System.Drawing.Size(75, 23);
            this.SaveImg_B.TabIndex = 31;
            this.SaveImg_B.Text = "Сохранить";
            this.SaveImg_B.UseVisualStyleBackColor = true;
            this.SaveImg_B.Click += new System.EventHandler(this.SaveImg_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(194, 261);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(75, 23);
            this.Delete_B.TabIndex = 32;
            this.Delete_B.Text = "Удалить";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // End_B
            // 
            this.End_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_B.Location = new System.Drawing.Point(133, 686);
            this.End_B.Name = "End_B";
            this.End_B.Size = new System.Drawing.Size(111, 43);
            this.End_B.TabIndex = 33;
            this.End_B.Text = "Закончить";
            this.End_B.UseVisualStyleBackColor = true;
            this.End_B.Click += new System.EventHandler(this.End_B_Click);
            // 
            // Save_B
            // 
            this.Save_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_B.Location = new System.Drawing.Point(250, 686);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(111, 43);
            this.Save_B.TabIndex = 34;
            this.Save_B.Text = "Сохранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_B.Location = new System.Drawing.Point(367, 686);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(111, 43);
            this.Exit_B.TabIndex = 35;
            this.Exit_B.Text = "Отмена";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // SaveImg_D
            // 
            this.SaveImg_D.Filter = "image file (*.jpg, *.png) |*.jpg;*.png|All files|*.*";
            // 
            // OrderImage_D
            // 
            this.OrderImage_D.Filter = "image file (*.jpg, *.png) |*.jpg;*.png|All files|*.*";
            // 
            // OrderInProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 741);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.End_B);
            this.Controls.Add(this.Delete_B);
            this.Controls.Add(this.SaveImg_B);
            this.Controls.Add(this.Upload_B);
            this.Controls.Add(this.OrderCLogin_TB);
            this.Controls.Add(this.OrderALogin_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderDecs_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderPrice_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderName_TB);
            this.Controls.Add(this.Order_Img);
            this.Controls.Add(this.label1);
            this.Name = "OrderInProgressForm";
            this.Text = "OrderInProgress";
            ((System.ComponentModel.ISupportInitialize)(this.Order_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderCLogin_TB;
        private System.Windows.Forms.TextBox OrderALogin_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderDecs_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderPrice_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderName_TB;
        private System.Windows.Forms.PictureBox Order_Img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Upload_B;
        private System.Windows.Forms.Button SaveImg_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button End_B;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.SaveFileDialog SaveImg_D;
        private System.Windows.Forms.OpenFileDialog OrderImage_D;
    }
}
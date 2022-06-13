using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    partial class OrderEditing
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
            this.Order_Img = new System.Windows.Forms.PictureBox();
            this.OrderName_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderPrice_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderDecs_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderCLogin_TB = new System.Windows.Forms.TextBox();
            this.OrderALogin_TB = new System.Windows.Forms.TextBox();
            this.OrderImage_D = new System.Windows.Forms.OpenFileDialog();
            this.SaveImg_D = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Img)).BeginInit();
            this.SuspendLayout();


            Save_B = new Button();
            Cancel_B = new Button();
            Change_B = new Button();
            Delete_B = new Button();
            ChangeImg_B = new Button();
            SaveImg_B = new Button();
            DeleteImg_B = new Button();
            // 
            // Save_B
            // 
            Save_B.Enabled = false;
            Save_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_B.Location = new Point(93, 705);
            Save_B.Name = "Save_B";
            Save_B.Size = new Size(111, 43);
            Save_B.TabIndex = 0;
            Save_B.Text = "Сохранить";
            Save_B.UseVisualStyleBackColor = true;
            Save_B.Click += Save_B_Click;
            // 
            // Cancel_B
            // 
            Cancel_B.Enabled = false;
            Cancel_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel_B.Location = new Point(210, 705);
            Cancel_B.Name = "Cancel_B";
            Cancel_B.Size = new Size(111, 43);
            Cancel_B.TabIndex = 1;
            Cancel_B.Text = "Сбросить";
            Cancel_B.UseVisualStyleBackColor = true;
            Cancel_B.Click += Cancel_B_Click;
            // 
            // Change_B
            // 
            Change_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Change_B.Location = new Point(327, 705);
            Change_B.Name = "Change_B";
            Change_B.Size = new Size(111, 43);
            Change_B.TabIndex = 2;
            Change_B.Text = "Изменить";
            Change_B.UseVisualStyleBackColor = true;
            Change_B.Click += Change_B_Click;
            // 
            // Delete_B
            // 
            Delete_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_B.Location = new Point(444, 705);
            Delete_B.Name = "Delete_B";
            Delete_B.Size = new Size(111, 43);
            Delete_B.TabIndex = 3;
            Delete_B.Text = "Удалить";
            Delete_B.UseVisualStyleBackColor = true;
            Delete_B.Click += Delete_B_Click;
            // 
            // ChangeImg_B
            // 
            ChangeImg_B.Enabled = false;
            ChangeImg_B.Location = new Point(48, 269);
            ChangeImg_B.Name = "ChangeImg_B";
            ChangeImg_B.Size = new Size(75, 23);
            ChangeImg_B.TabIndex = 23;
            ChangeImg_B.Text = "Изменить";
            ChangeImg_B.UseVisualStyleBackColor = true;
            ChangeImg_B.Click += Order_Img_Click;
            // 
            // SaveImg_B
            // 
            SaveImg_B.Location = new Point(133, 269);
            SaveImg_B.Name = "SaveImg_B";
            SaveImg_B.Size = new Size(75, 23);
            SaveImg_B.TabIndex = 24;
            SaveImg_B.Text = "Скачать";
            SaveImg_B.UseVisualStyleBackColor = true;
            SaveImg_B.Click += SaveImg_B_Click;
            // 
            // DeleteImg_B
            // 
            DeleteImg_B.Enabled = false;
            DeleteImg_B.Location = new Point(214, 269);
            DeleteImg_B.Name = "DeleteImg_B";
            DeleteImg_B.Size = new Size(75, 23);
            DeleteImg_B.TabIndex = 25;
            DeleteImg_B.Text = "Удалить";
            DeleteImg_B.UseVisualStyleBackColor = true;
            DeleteImg_B.Click += DeleteImg_B_Click;

            Controls.Add(DeleteImg_B);
            Controls.Add(SaveImg_B);
            Controls.Add(ChangeImg_B);
            Controls.Add(Delete_B);
            Controls.Add(Change_B);
            Controls.Add(Cancel_B);
            Controls.Add(Save_B);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Покупатель";
            // 
            // Order_Img
            // 
            this.Order_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Order_Img.Enabled = false;
            this.Order_Img.Location = new System.Drawing.Point(28, 21);
            this.Order_Img.Name = "Order_Img";
            this.Order_Img.Size = new System.Drawing.Size(605, 242);
            this.Order_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Order_Img.TabIndex = 5;
            this.Order_Img.TabStop = false;
            // 
            // OrderName_TB
            // 
            this.OrderName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName_TB.Location = new System.Drawing.Point(133, 305);
            this.OrderName_TB.Name = "OrderName_TB";
            this.OrderName_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderName_TB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цена";
            // 
            // OrderPrice_TB
            // 
            this.OrderPrice_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice_TB.Location = new System.Drawing.Point(133, 452);
            this.OrderPrice_TB.Name = "OrderPrice_TB";
            this.OrderPrice_TB.Size = new System.Drawing.Size(100, 29);
            this.OrderPrice_TB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            // 
            // OrderDecs_TB
            // 
            this.OrderDecs_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDecs_TB.Location = new System.Drawing.Point(133, 502);
            this.OrderDecs_TB.Multiline = true;
            this.OrderDecs_TB.Name = "OrderDecs_TB";
            this.OrderDecs_TB.Size = new System.Drawing.Size(500, 174);
            this.OrderDecs_TB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Создатель";
            // 
            // OrderCLogin_TB
            // 
            this.OrderCLogin_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCLogin_TB.Location = new System.Drawing.Point(133, 404);
            this.OrderCLogin_TB.Name = "OrderCLogin_TB";
            this.OrderCLogin_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderCLogin_TB.TabIndex = 18;
            // 
            // OrderALogin_TB
            // 
            this.OrderALogin_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderALogin_TB.Location = new System.Drawing.Point(133, 354);
            this.OrderALogin_TB.Name = "OrderALogin_TB";
            this.OrderALogin_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderALogin_TB.TabIndex = 17;
            // 
            // OrderImage_D
            // 
            this.OrderImage_D.Filter = "image file (*.jpg, *.png) |*.jpg;*.png|All files|*.*";
            this.OrderImage_D.FileOk += new System.ComponentModel.CancelEventHandler(this.OrderImage_D_FileOk);
            // 
            // SaveImg_D
            // 
            this.SaveImg_D.Filter = "image file (*.jpg, *.png) |*.jpg;*.png|All files|*.*";
            // 
            // OrderEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 761);
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
            this.Name = "OrderEditing";
            this.Text = "OrderEditing";
            ((System.ComponentModel.ISupportInitialize)(this.Order_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Order_Img;
        private System.Windows.Forms.TextBox OrderName_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderPrice_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderDecs_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderCLogin_TB;
        private System.Windows.Forms.TextBox OrderALogin_TB;
        private System.Windows.Forms.OpenFileDialog OrderImage_D;
        private System.Windows.Forms.SaveFileDialog SaveImg_D;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button ChangeImg_B;
        private System.Windows.Forms.Button SaveImg_B;
        private System.Windows.Forms.Button DeleteImg_B;
        private System.Windows.Forms.Button PlaceImg_B;
    }
}
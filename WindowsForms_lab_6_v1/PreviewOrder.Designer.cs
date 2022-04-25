namespace WindowsForms_lab_6_v1
{
    partial class PreviewOrder
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
            this.Exit_B = new System.Windows.Forms.Button();
            this.Select_B = new System.Windows.Forms.Button();
            this.OrderCLogin_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderDecs_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderPrice_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderName_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_B
            // 
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_B.Location = new System.Drawing.Point(344, 365);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(111, 43);
            this.Exit_B.TabIndex = 65;
            this.Exit_B.Text = "Отмена";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Select_B
            // 
            this.Select_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_B.Location = new System.Drawing.Point(227, 365);
            this.Select_B.Name = "Select_B";
            this.Select_B.Size = new System.Drawing.Size(111, 43);
            this.Select_B.TabIndex = 64;
            this.Select_B.Text = "Выбрать";
            this.Select_B.UseVisualStyleBackColor = true;
            this.Select_B.Click += new System.EventHandler(this.Select_B_Click);
            // 
            // OrderCLogin_TB
            // 
            this.OrderCLogin_TB.Enabled = false;
            this.OrderCLogin_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCLogin_TB.Location = new System.Drawing.Point(127, 70);
            this.OrderCLogin_TB.Name = "OrderCLogin_TB";
            this.OrderCLogin_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderCLogin_TB.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Название";
            // 
            // OrderDecs_TB
            // 
            this.OrderDecs_TB.Enabled = false;
            this.OrderDecs_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDecs_TB.Location = new System.Drawing.Point(127, 168);
            this.OrderDecs_TB.Multiline = true;
            this.OrderDecs_TB.Name = "OrderDecs_TB";
            this.OrderDecs_TB.Size = new System.Drawing.Size(500, 174);
            this.OrderDecs_TB.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Описание";
            // 
            // OrderPrice_TB
            // 
            this.OrderPrice_TB.Enabled = false;
            this.OrderPrice_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice_TB.Location = new System.Drawing.Point(127, 118);
            this.OrderPrice_TB.Name = "OrderPrice_TB";
            this.OrderPrice_TB.Size = new System.Drawing.Size(100, 29);
            this.OrderPrice_TB.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Цена";
            // 
            // OrderName_TB
            // 
            this.OrderName_TB.Enabled = false;
            this.OrderName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName_TB.Location = new System.Drawing.Point(127, 23);
            this.OrderName_TB.Name = "OrderName_TB";
            this.OrderName_TB.Size = new System.Drawing.Size(209, 29);
            this.OrderName_TB.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Покупатель";
            // 
            // PreviewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Select_B);
            this.Controls.Add(this.OrderCLogin_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderDecs_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderPrice_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderName_TB);
            this.Controls.Add(this.label1);
            this.Name = "PreviewOrder";
            this.Text = "PreviewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Select_B;
        private System.Windows.Forms.TextBox OrderCLogin_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderDecs_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderPrice_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderName_TB;
        private System.Windows.Forms.Label label1;
    }
}
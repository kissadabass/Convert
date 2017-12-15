namespace CIS_Projac1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.BT3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(509, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "ออกจากโปรแกรม";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(45, 130);
            this.num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(287, 54);
            this.num.TabIndex = 1;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB1.Location = new System.Drawing.Point(449, 126);
            this.RB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(94, 29);
            this.RB1.TabIndex = 2;
            this.RB1.TabStop = true;
            this.RB1.Text = "กิโลเมตร";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB2.Location = new System.Drawing.Point(583, 126);
            this.RB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(68, 29);
            this.RB2.TabIndex = 3;
            this.RB2.TabStop = true;
            this.RB2.Text = "เมตร";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB3.Location = new System.Drawing.Point(449, 174);
            this.RB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(109, 29);
            this.RB3.TabIndex = 4;
            this.RB3.TabStop = true;
            this.RB3.Text = "เซนติเมตร";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB4.Location = new System.Drawing.Point(583, 174);
            this.RB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(88, 29);
            this.RB4.TabIndex = 5;
            this.RB4.TabStop = true;
            this.RB4.Text = "มิลิเมตร";
            this.RB4.UseVisualStyleBackColor = true;
            this.RB4.CheckedChanged += new System.EventHandler(this.RB4_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(605, 316);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "ล้างข้อมูล";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT3
            // 
            this.BT3.BackColor = System.Drawing.Color.Aqua;
            this.BT3.Location = new System.Drawing.Point(255, 226);
            this.BT3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(197, 58);
            this.BT3.TabIndex = 8;
            this.BT3.Text = "แสดงผลลัพท์";
            this.BT3.UseVisualStyleBackColor = false;
            this.BT3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "โปรแกรมแปลงค่าความยาว";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "ใส่ค่าที่ต้องการแปลง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "เลือกหน่วยของค่าที่จะแปลง";
            // 
            // Show
            // 
            this.Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show.Location = new System.Drawing.Point(71, 290);
            this.Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show.Name = "Show";
            this.Show.RowTemplate.Height = 24;
            this.Show.Size = new System.Drawing.Size(528, 263);
            this.Show.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 626);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RB4);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Show;
    }
}


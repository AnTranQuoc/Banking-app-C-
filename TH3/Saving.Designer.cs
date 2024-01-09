namespace TH3
{
    partial class Saving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saving));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_acnumber = new System.Windows.Forms.TextBox();
            this.textBox2_money = new System.Windows.Forms.TextBox();
            this.textBox3_introducer = new System.Windows.Forms.TextBox();
            this.button1_dangnhap = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 75);
            this.label1.TabIndex = 15;
            this.label1.Text = "UIT";
            // 
            // textBox1_acnumber
            // 
            this.textBox1_acnumber.BackColor = System.Drawing.Color.LightGray;
            this.textBox1_acnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_acnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_acnumber.Location = new System.Drawing.Point(70, 230);
            this.textBox1_acnumber.Multiline = true;
            this.textBox1_acnumber.Name = "textBox1_acnumber";
            this.textBox1_acnumber.Size = new System.Drawing.Size(259, 27);
            this.textBox1_acnumber.TabIndex = 16;
            // 
            // textBox2_money
            // 
            this.textBox2_money.BackColor = System.Drawing.Color.LightGray;
            this.textBox2_money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_money.Location = new System.Drawing.Point(70, 303);
            this.textBox2_money.Multiline = true;
            this.textBox2_money.Name = "textBox2_money";
            this.textBox2_money.Size = new System.Drawing.Size(259, 27);
            this.textBox2_money.TabIndex = 17;
            // 
            // textBox3_introducer
            // 
            this.textBox3_introducer.BackColor = System.Drawing.Color.LightGray;
            this.textBox3_introducer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3_introducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_introducer.Location = new System.Drawing.Point(70, 499);
            this.textBox3_introducer.Multiline = true;
            this.textBox3_introducer.Name = "textBox3_introducer";
            this.textBox3_introducer.Size = new System.Drawing.Size(259, 27);
            this.textBox3_introducer.TabIndex = 19;
            // 
            // button1_dangnhap
            // 
            this.button1_dangnhap.BackColor = System.Drawing.Color.Black;
            this.button1_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_dangnhap.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1_dangnhap.Location = new System.Drawing.Point(63, 647);
            this.button1_dangnhap.Name = "button1_dangnhap";
            this.button1_dangnhap.Size = new System.Drawing.Size(278, 35);
            this.button1_dangnhap.TabIndex = 20;
            this.button1_dangnhap.Text = "Create";
            this.button1_dangnhap.UseVisualStyleBackColor = false;
            this.button1_dangnhap.Click += new System.EventHandler(this.button1_dangnhap_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.White;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(58, 345);
            this.balance.Name = "balance";
            this.balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.balance.Size = new System.Drawing.Size(83, 25);
            this.balance.TabIndex = 21;
            this.balance.Text = "Balence";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_label.Location = new System.Drawing.Point(60, 538);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 20);
            this.error_label.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Không kỳ hạn - 0.10%",
            "1 tháng - 0.20%",
            "3 tháng - 0.80%",
            "8 tháng - 4%",
            "12 tháng - 5.50%",
            "24 tháng - 6%"});
            this.comboBox1.Location = new System.Drawing.Point(64, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // Saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.button1_dangnhap);
            this.Controls.Add(this.textBox3_introducer);
            this.Controls.Add(this.textBox2_money);
            this.Controls.Add(this.textBox1_acnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Saving";
            this.Text = "Saving";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_acnumber;
        private System.Windows.Forms.TextBox textBox2_money;
        private System.Windows.Forms.TextBox textBox3_introducer;
        private System.Windows.Forms.Button button1_dangnhap;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
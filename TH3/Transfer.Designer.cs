namespace TH3
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.balance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2_UITBank = new System.Windows.Forms.PictureBox();
            this.pictureBox3_QRCode = new System.Windows.Forms.PictureBox();
            this.pictureBox4_OtherBank = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_UITBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_OtherBank)).BeginInit();
            this.SuspendLayout();
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.White;
            this.balance.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(12, 213);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(358, 33);
            this.balance.TabIndex = 2;
            this.balance.Text = "9.000$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 412);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2_UITBank
            // 
            this.pictureBox2_UITBank.Image = global::TH3.Properties.Resources.UITBANK;
            this.pictureBox2_UITBank.Location = new System.Drawing.Point(12, 260);
            this.pictureBox2_UITBank.Name = "pictureBox2_UITBank";
            this.pictureBox2_UITBank.Size = new System.Drawing.Size(115, 32);
            this.pictureBox2_UITBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_UITBank.TabIndex = 5;
            this.pictureBox2_UITBank.TabStop = false;
            this.pictureBox2_UITBank.Click += new System.EventHandler(this.pictureBox2UITBank_Click);
            // 
            // pictureBox3_QRCode
            // 
            this.pictureBox3_QRCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_QRCode.Image")));
            this.pictureBox3_QRCode.Location = new System.Drawing.Point(279, 260);
            this.pictureBox3_QRCode.Name = "pictureBox3_QRCode";
            this.pictureBox3_QRCode.Size = new System.Drawing.Size(110, 32);
            this.pictureBox3_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3_QRCode.TabIndex = 6;
            this.pictureBox3_QRCode.TabStop = false;
            this.pictureBox3_QRCode.Click += new System.EventHandler(this.pictureBox3_QRCode_Click);
            // 
            // pictureBox4_OtherBank
            // 
            this.pictureBox4_OtherBank.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4_OtherBank.Image")));
            this.pictureBox4_OtherBank.Location = new System.Drawing.Point(132, 260);
            this.pictureBox4_OtherBank.Name = "pictureBox4_OtherBank";
            this.pictureBox4_OtherBank.Size = new System.Drawing.Size(136, 32);
            this.pictureBox4_OtherBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4_OtherBank.TabIndex = 7;
            this.pictureBox4_OtherBank.TabStop = false;
            this.pictureBox4_OtherBank.Click += new System.EventHandler(this.pictureBox4_OtherBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 75);
            this.label1.TabIndex = 14;
            this.label1.Text = "UIT";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4_OtherBank);
            this.Controls.Add(this.pictureBox3_QRCode);
            this.Controls.Add(this.pictureBox2_UITBank);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balance);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_UITBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_OtherBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2_UITBank;
        private System.Windows.Forms.PictureBox pictureBox3_QRCode;
        private System.Windows.Forms.PictureBox pictureBox4_OtherBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
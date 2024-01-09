namespace TH3
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
            this.textBox1_tk = new System.Windows.Forms.TextBox();
            this.textBox2_mk = new System.Windows.Forms.TextBox();
            this.linkLabel1_Quenmk = new System.Windows.Forms.LinkLabel();
            this.linkLabel2_Dangky = new System.Windows.Forms.LinkLabel();
            this.button1_dangnhap = new System.Windows.Forms.Button();
            this.savepass = new System.Windows.Forms.CheckBox();
            this.eye = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_tk
            // 
            this.textBox1_tk.BackColor = System.Drawing.Color.LightGray;
            this.textBox1_tk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_tk.Location = new System.Drawing.Point(74, 426);
            this.textBox1_tk.Multiline = true;
            this.textBox1_tk.Name = "textBox1_tk";
            this.textBox1_tk.Size = new System.Drawing.Size(259, 27);
            this.textBox1_tk.TabIndex = 2;
            // 
            // textBox2_mk
            // 
            this.textBox2_mk.BackColor = System.Drawing.Color.LightGray;
            this.textBox2_mk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_mk.Location = new System.Drawing.Point(74, 497);
            this.textBox2_mk.Multiline = true;
            this.textBox2_mk.Name = "textBox2_mk";
            this.textBox2_mk.PasswordChar = '*';
            this.textBox2_mk.Size = new System.Drawing.Size(220, 27);
            this.textBox2_mk.TabIndex = 3;
            this.textBox2_mk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_mk_KeyDown);
            // 
            // linkLabel1_Quenmk
            // 
            this.linkLabel1_Quenmk.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1_Quenmk.AutoSize = true;
            this.linkLabel1_Quenmk.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1_Quenmk.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1_Quenmk.Location = new System.Drawing.Point(140, 651);
            this.linkLabel1_Quenmk.Name = "linkLabel1_Quenmk";
            this.linkLabel1_Quenmk.Size = new System.Drawing.Size(129, 16);
            this.linkLabel1_Quenmk.TabIndex = 4;
            this.linkLabel1_Quenmk.TabStop = true;
            this.linkLabel1_Quenmk.Text = "Fogotten password?";
            this.linkLabel1_Quenmk.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1_Quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2_Dangky
            // 
            this.linkLabel2_Dangky.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel2_Dangky.AutoSize = true;
            this.linkLabel2_Dangky.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2_Dangky.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2_Dangky.Location = new System.Drawing.Point(176, 680);
            this.linkLabel2_Dangky.Name = "linkLabel2_Dangky";
            this.linkLabel2_Dangky.Size = new System.Drawing.Size(47, 16);
            this.linkLabel2_Dangky.TabIndex = 5;
            this.linkLabel2_Dangky.TabStop = true;
            this.linkLabel2_Dangky.Text = "Sign in";
            this.linkLabel2_Dangky.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2_Dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1_dangnhap
            // 
            this.button1_dangnhap.BackColor = System.Drawing.Color.Black;
            this.button1_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_dangnhap.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1_dangnhap.Location = new System.Drawing.Point(66, 563);
            this.button1_dangnhap.Name = "button1_dangnhap";
            this.button1_dangnhap.Size = new System.Drawing.Size(270, 35);
            this.button1_dangnhap.TabIndex = 6;
            this.button1_dangnhap.Text = "Login";
            this.button1_dangnhap.UseVisualStyleBackColor = false;
            this.button1_dangnhap.Click += new System.EventHandler(this.button1_dangnhap_Click);
            // 
            // savepass
            // 
            this.savepass.AutoSize = true;
            this.savepass.Location = new System.Drawing.Point(63, 536);
            this.savepass.Name = "savepass";
            this.savepass.Size = new System.Drawing.Size(130, 20);
            this.savepass.TabIndex = 7;
            this.savepass.Text = "Save password?";
            this.savepass.UseVisualStyleBackColor = true;
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.Transparent;
            this.eye.Image = global::TH3.Properties.Resources._8530588_eye_slash_icon;
            this.eye.Location = new System.Drawing.Point(303, 493);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(30, 30);
            this.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye.TabIndex = 8;
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.savepass);
            this.Controls.Add(this.button1_dangnhap);
            this.Controls.Add(this.linkLabel2_Dangky);
            this.Controls.Add(this.linkLabel1_Quenmk);
            this.Controls.Add(this.textBox2_mk);
            this.Controls.Add(this.textBox1_tk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1_tk;
        private System.Windows.Forms.TextBox textBox2_mk;
        private System.Windows.Forms.LinkLabel linkLabel1_Quenmk;
        private System.Windows.Forms.LinkLabel linkLabel2_Dangky;
        private System.Windows.Forms.Button button1_dangnhap;
        private System.Windows.Forms.CheckBox savepass;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.Button button1;
    }
}

